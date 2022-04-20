const Http = new XMLHttpRequest();
const url = 'http://localhost:5001/index.html';
Http.open("GET", url);
Http.send();

Http.onreadystatechange = (e) => {
    console.log(Http.responseText)
}

function onDelete() {
    var id = document.getElementById("selectedTaskId").value;
    const deleted = await fetch(`http://localhost:5001/index.html/${id}`, {
        method: "DELETE",
        headers: { "Content-Type": "application/json" }
    });
}

/*
Through the URL, it will establish the connection with the backend. When we click on the delete button, function "onDelete" will run. it will fetch
the task id and delete that task.
*/