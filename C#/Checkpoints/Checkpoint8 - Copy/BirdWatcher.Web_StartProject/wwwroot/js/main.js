
async function recreateDatabase() {
    //document.getElementById("recreateButton").style.display = "none";
    //document.body.style.backgroundColor = "blue";
    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    //if (response.status === 200) {
    //    document.getElementById("recreateButton").style.display = "block";
    //    document.body.style.backgroundColor = "green";
        
    //} else {
    //    document.getElementById("recreateButton").style.display = "block";
    //    document.body.style.backgroundColor = "red";

    //}

}

async function clickAddBird() {
    let birdObservation = document.getElementById("addObservationBird").value;
    
    let response = await fetch(`observation/add`, {
        method: "POST",
        body: JSON.stringify(
            {
                name: birdObservation
            }),
        headers: {
            "Content-Type": "application/json"
        }

    });

    if (response.status === 200) {
        console.log("Observation added!")
    }
}

async function clickShowObservations() {
    let a = document.getElementById("showObservations")

    if (a.style.display === "none") {
        a.style.display = "block";

        let response = await fetch(`observation/get`)

        //if (response.status === 200) {

            let birdObservations = await response.json();

            console.log("birdObservations", birdObservations);
            let html = "<h3>All observations </h3>";
            for (let n of birdObservations) {
                html += `<tr><td>${n.name}</td></tr><br />`
            }
            document.getElementById("showObservations").innerHTML = html;
        //}

    } else {
        a.style.display = "none";
    }
}
