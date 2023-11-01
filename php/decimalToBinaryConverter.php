<?php
function decimalToBinary($decimal) {
    if ($decimal == 0) {
        return "0";
    }

    $binary = "";
    while ($decimal > 0) {
        $remainder = $decimal % 2;
        $binary = $remainder . $binary;
        $decimal = (int)($decimal / 2);
    }

    return $binary;
}

if ($_SERVER["REQUEST_METHOD"] === "POST" && isset($_POST["decimal"])) {
    $decimal = (int)$_POST["decimal"];
    $binaryResult = decimalToBinary($decimal);
    echo $binaryResult;
}
?>
