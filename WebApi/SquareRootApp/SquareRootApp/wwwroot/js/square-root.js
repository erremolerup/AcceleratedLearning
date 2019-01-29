async function Alert() {

    let number = document.getElementById("number").value;
    //alert(`Du angav ${number}`)
    //document.getElementById("result").innerText = `Du angav ${number}`;

    let response = await fetch(`/squareroot?number=${number}`);

    document.getElementById("result").innerText = "";
    document.getElementById("error").innerText = "";

    if (response.status == 200) {

        let result = await response.json();
        document.getElementById("result").innerText = result;
        
    }
    else {
        let error = await response.text();
        document.getElementById("error").innerText = error;
    }
}


