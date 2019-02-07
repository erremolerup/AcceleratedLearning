
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
    let dateObservation = document.getElementById("addObservationDate").value;
    let locationObservation = document.getElementById("addObservationLocation").value;
    let notesObservation = document.getElementById("addObservationNotes").value;

    let response = await fetch(`observation/add`, {
        method: "POST",
        body: JSON.stringify(
            {
                datetime: dateObservation,
                name: birdObservation,
                location: locationObservation,
                notes: notesObservation
            }),
        headers: {
            "Content-Type": "application/json"
        }

    });

    if (response.status === 200) {
        console.log("Observation added!")
    }
    clickShowObservations();
    
}

async function clickShowObservations() {
   
    let a = document.getElementById("showObservations")
   

    let response = await fetch(`observation/get`)

    let birdObservations = await response.json();
    console.log(birdObservations);
   
    let html = "<div><h3>All observations</h3><table><thead><tr> <td>Date</td> <td>Species</td> <td>Location</td> <td>Notes</td></tr></thead>";

    for (let n of birdObservations) {
        html += `<tr><td>${n.dateTime}</td><td>${n.name}</td><td>${n.location}</td><td>${n.notes}</td></tr>`
    }
    document.getElementById("showObservations").innerHTML = html + '</table></div>';

    showSpecies();
    }
   
    async function showSpecies() {
        let b = document.getElementById("showSpecies")
        let response = await fetch(`observation/get`)

        let birdObservations = await response.json();
        let html2 = "<h3>Species</h3><table>";

        for (let n of birdObservations) {
            html2 += `<tr><td>${n.name}</td></tr><br />`
        }
        document.getElementById("showSpecies").innerHTML = html2 + `</table>`;
    }

