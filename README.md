# nsisong-decimal-to-binary-converter

Okay, this is supposed to be a simple C# program I created to demonstrate how to convert a decimal number to its binary representation. In binary, each number is composed of elements called "bits," and each bit can be either 1 or 0.

## How It Works

The program provides a `toBinary` function, which takes an integer as input and returns its binary representation as a string. Here's how it works:

1. If the input number is 0, the function returns "0" since 0 in decimal is also 0 in binary.

2. For non-zero input numbers, the function initializes an empty string called `binary` to store the binary representation.

3. It enters a `while` loop, which continues until the input number (`n`) becomes zero.

4. Inside the loop, the `%` (modulus) operator is used to find the remainder of the division of `n` by 2. This remainder (either 0 or 1) represents the current least significant bit.

5. The result (0 or 1) is then appended to the beginning of the `binary` string. This operation effectively builds the binary representation from right to left.

6. The `n` is divided by 2, effectively shifting it one bit to the right.

7. Steps 4-6 are repeated until `n` becomes zero, ensuring the entire binary representation is constructed.
