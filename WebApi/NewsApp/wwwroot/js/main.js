console.log("Moi Mukulat!");

async function clickSeed() {

    let news = document.getElementById("news").value;

    let response = await fetch(`api/news/seed`, {
        method: "POST"
    });

    if (response.status === 204) {
        console.log("Seed done!");
    } else {
        console.log("Unexpected error")
    }
}

async function clickShowAllNews() {

    let x = document.getElementById("newsList");

    if (x.style.display === "none") {
        x.style.display = "block";

        let response = await fetch(`api/news`);

        if (response.status === 200) {

            let allNews = await response.json();

            console.log("allNews", allNews);

            let html = " <h3>News TaAble</h3><table>";

            for (let n of allNews) {
                html += `<tr><td>Id: ${n.id}</td> <td>Rubrik: ${n.header}</td> <td> Intro: ${n.intro} </td> <td> <button onclick="clickUpdateNews()">Update</button> </td></tr>`;
            }
            document.getElementById("newsList").innerHTML = html + `</table>`;

        } else {
            console.log("Unexpected error", response);
        }
    }
    else {
        x.style.display = "none";
    }
}

async function clickShowAddNews() {

    let y = document.getElementById("addArea");

    if (y.style.display === "none") {
        y.style.display = "block";

        let categories = document.getElementById("addAreaCategory")
        let response = await fetch("api/categories")

        
        if (response.status === 200) {
            let newsCategories = await response.json();

            let html = "";
            for (let n of newsCategories) {
                html += `<option value=${n.id}> ${n.name} </option>`
            }
            document.getElementById("addAreaCategory").innerHTML = html;
        }
       
    } else {
        y.style.display = "none";
    }
}

async function clickAddNews() {

    let header = document.getElementById("addAreaHeader").value;
    let intro = document.getElementById("addAreaIntro").value;
    let body = document.getElementById("addAreaBody").value;
    let category = document.getElementById("addAreaCategory").value;

   
    let response = await fetch("api/news", {
        method: "POST",
        body: JSON.stringify(
            {
                header: header,
                intro: intro,
                body: body,
                category: {
                    "id": 1
                }
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (header < 5) {
        document.getElementById("addAreaError").innerHTML = `Error message: The header must be longer than 5 characters`;
    }
}

async function clickRecreate() {

}

async function clickStatArea() {
    let a = document.getElementById("statArea");

    if (a.style.display === "none") {
        a.style.display = "block";

        let numberOfNews = document.getElementById("nrOfNews");
        let response = await fetch(`api/news/count`);

        if (response.status === 200) {

            let numberNews = await response.json();
            document.getElementById("nrOfNews").innerText = numberNews;
        }

    } else {
        a.style.display = "none";
    }
}