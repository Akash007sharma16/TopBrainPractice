function getValues() {
    let num1 = parseFloat(document.getElementById("num1").value);
    let num2 = parseFloat(document.getElementById("num2").value);

    if (isNaN(num1) || isNaN(num2)) {
        alert("Please enter both numbers");
        return null;
    }

    return { num1, num2 };
}

function add() {
    let values = getValues();
    if (!values) return;

    let result = values.num1 + values.num2;
    document.getElementById("result").innerHTML =
        `Result: ${values.num1} + ${values.num2} = ${result}`;
}

function subtract() {
    let values = getValues();
    if (!values) return;

    let result = values.num1 - values.num2;
    document.getElementById("result").innerHTML =
        `Result: ${values.num1} - ${values.num2} = ${result}`;
}

function multiply() {
    let values = getValues();
    if (!values) return;

    let result = values.num1 * values.num2;
    document.getElementById("result").innerHTML =
        `Result: ${values.num1} × ${values.num2} = ${result}`;
}

function divide() {
    let values = getValues();
    if (!values) return;

    if (values.num2 === 0) {
        alert("Cannot divide by zero");
        return;
    }

    let result = values.num1 / values.num2;
    document.getElementById("result").innerHTML =
        `Result: ${values.num1} ÷ ${values.num2} = ${result}`;
}