# AdmissionImproved

This program outputs whether "admission" requirements have been met based on user input.

## Usage/Examples

```
Please enter your Grade Point Average: random input
Invalid entry! Enter a positive value up to 4.0:
3.8
Enter your Admission Test Score: -1
Invalid entry! Enter a positive value up to 100:
87
Accept

Press any key to close this window . . .
```

### Program Logic:

- Using the previous [Admission Program](https:\\github.com\josephestes\Admission), check for reasonable inputs (or reject un-reasonable ones) such as
  1. Negative GPA or test scores
  2. A GPA of 10
  3. A test score of more than 100
- Remain in a loop until a valid input is entered, then exit the loop
