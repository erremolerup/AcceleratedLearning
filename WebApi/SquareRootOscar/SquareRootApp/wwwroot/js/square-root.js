// Syfte: samma exempel men med async och await => lite kortare och mycket lättare att läsa

let errorMessage = "";
let result = "";

function render() {
    document.getElementById("error").innerText = errorMessage;
    document.getElementById("result").innerText = result;
}

async function squareRoot() {

    let number = document.getElementById("number").value;

    let response = await fetch(`api/squareroot?number=${number}`);

    if (response.status === 200) {

        result = await response.json();
        errorMessage = "";

    }  else if (response.status === 400) {

        result = "";
        errorMessage = await response.text();

    } else {
        result = "";
        errorMessage = `Unexpected (status code=${response.status})`;
    }
    render();

}

async function squareRoot_Alternative() {

    let number = document.getElementById("number").value;

    let response = await fetch(`api/squareroot-alternative?number=${number}`);

    if (response.status === 200) {

        result = await response.json();
        errorMessage = "";

    } else if (response.status === 400) {

        result = "";
        errorMessage = (await response.json()).errorMessage;

    } else {
        result = "";
        errorMessage = `Unexpected (status code=${response.status})`;
    }
    render();

}
