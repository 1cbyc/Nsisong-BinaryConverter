# nsisong-decimal-to-binary-converter

Okay, this is supposed to be a simple C# program I created to demonstrate how to convert a decimal number to its binary representation. In binary, each number is composed of elements called "bits," and each bit can be either 1 or 0.

## How It Works

The program provides a `toBinary` function, which takes an integer as input and returns its binary representation as a string. Here's how it works:

1. If the input number is 0, the function returns "0" since 0 in decimal is also 0 in binary.

2. For non-zero input numbers, the function initializes an empty string called `binary` to store the binary representation.

3. It enters a `while` loop, which continues until the input number (`n`) becomes zero.
