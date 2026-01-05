# Ecommerce Payment – Technical Assignment  
Avalpha Technologies

This assignment is about completing an Ecommerce Payment flow using the given React frontend and .NET backend.

The project already provides a basic structure for both frontend and backend, but the actual business logic and integration are incomplete. The goal is not just to make the application work, but to show how I approach a problem, structure my code, and make reasonable decisions within a limited time.

---

## What I Implemented

As part of this task, I worked on the following:

- Connected the React frontend with the C#/.NET backend
- Implemented discount calculation based on the credit card type
- Ensured that when the user clicks the **Pay** button:
  - Required payment data is sent to the backend
  - Discount is calculated correctly
  - Final payable amount is clearly shown on the UI
- Focused on writing clean and readable code with proper structure
- Added basic validation and handled errors gracefully

---

## Time Consideration

The assignment was time-boxed to a maximum of 4 hours.  
I focused on completing the core requirements correctly instead of trying to make everything perfect.

Some advanced features were intentionally skipped, and the reasons are mentioned in the notes.

---

## Discount Rules Implemented

The discount is calculated based on the credit card number prefix:

| Card Type | Discount |
|---------|----------|
| Visa | 0% |
| MasterCard | 5% |
| RuPay | 10% |

### Card Type Detection Logic

- If card number starts with `4` → Visa
- If card number starts with `5` → MasterCard
- If card number starts with `6` → RuPay
- Any other case → RuPay (default)

The default is always RuPay, even if the card number does not match any known prefix, as mentioned in the requirements.

---

## Tasks Covered

- Connected frontend and backend using REST API
- Identified credit card type from card number
- Implemented discount calculation logic in backend
- Added basic credit card validation
- Returned a structured response (DTO) from backend
- Displayed the following clearly on UI:
  - Total amount
  - Discount applied
  - Final payable amount
  - Currency formatting (INR)
- Handled errors on both frontend and backend
- Added documentation explaining setup and decisions
- Used small and meaningful Git commits

---

## Testing

Automated tests were optional, so the focus was on manual testing:

- Verified discount logic for all card types
- Tested valid and invalid inputs
- Ensured API contract matches frontend usage

---

## Technology Used

### Frontend
- React (Vite)
- Fetch API

### Backend
- ASP.NET Core Web API (C#)
- MVC Controller pattern

---

## What Was Not Included

The following were intentionally skipped as they were not required:

- Authentication or authorization
- Database integration
- Payment gateway integration
- Advanced UI styling
- Over-engineered abstractions

---

## Final Checklist

Before submission, I ensured that:

- The application runs locally
- Discount logic works correctly
- UI clearly shows the discount and final amount
- Errors are handled properly
- `README-notes.md` is included
- Feature branch is pushed
- Commit history is clean and meaningful