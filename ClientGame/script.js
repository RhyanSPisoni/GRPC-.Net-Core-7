document.getElementById("GetGame").addEventListener("click", GetGame);
document.getElementById("NewGame").addEventListener("click", NewGame);
document.getElementById("DeleteGame").addEventListener("click", DeleteGame);

function GetGame() {
    let req = {
        Id: parseInt(document.getElementById("id").value),
    }

    fetch("https://localhost:7099/Get", {
        method: 'POST',
        body: JSON.stringify(req),
        headers: {
            'content-type': 'application/json'
        }
    }).then(res => {
        return res.json();
    }).then(res => {
        console.log(res)
        document.getElementById("inome").value = res.nome;
        document.getElementById("ivalor").value = res.valor;
        res = null
    })
}

function NewGame() {
    let req = {
        Id: parseInt(document.getElementById("id").value),
        Nome: document.getElementById("inome").value,
        valor: parseInt(document.getElementById('ivalor').value)
    }

    fetch("https://localhost:7099/New", {
        method: 'POST',
        body: JSON.stringify(req),
        mode: "cors",
        headers: {
            'content-type': 'application/json'
        }
    }).then(res => {
        return res.json();
    }).then(res => {

        console.log(res)


        document.getElementById("id").value = "";
        document.getElementById("inome").value = "";
        document.getElementById("ivalor").value = 0;
    })
}

function DeleteGame() {
    let req = {
        id: parseInt(document.getElementById("id").value)
    }

    console.log(req.id)

    fetch("https://localhost:7099/Delete", {
        method: 'POST',
        body: JSON.stringify(req),
        headers: {
            'content-type': 'application/json'
        }
    }).then(res => {
        return res.json();
    }).then(res => {
        document.getElementById("id").value = "";
        document.getElementById("inome").value = "";
        document.getElementById("ivalor").value = 0;
    })
}