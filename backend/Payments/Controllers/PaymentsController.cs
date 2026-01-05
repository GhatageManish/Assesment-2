using Microsoft.AspNetCore.Mvc;
using Payments;
using Payments.Domain;

namespace Payments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentsController : ControllerBase
    {
        [HttpPost("Pay")]
        public IActionResult Pay([FromBody] PaymentRequest request)
        {
            // Basic validation
            if (request == null ||
                request.Amount <= 0 ||
                request.CardDetails == null ||
                string.IsNullOrWhiteSpace(request.CardDetails.CardNumber))
            {
                return BadRequest("Invalid payment request");
            }

            // Detect card type
            var cardType = CalculateDiscount.GetCardType(
                request.CardDetails.CardNumber
            );

            // Calculate discount
            var (discountApplied, finalAmount) =
                CalculateDiscount.Calculate(cardType, request.Amount);

            // Prepare response
            var response = new PaymentResponse
            {
                OriginalAmount = request.Amount,
                CardType = cardType.ToString(),
                DiscountApplied = discountApplied,
                FinalAmount = finalAmount
            };

            return Ok(response);
        }
    }
}