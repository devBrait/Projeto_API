document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector(".form-cadastro");

    form.addEventListener("submit", function (event) {
        event.preventDefault();

        const nome = document.getElementById("exampleInputName1").value;
        const email = document.getElementById("exampleInputEmail1").value;
        const senha = document.getElementById("exampleInputPassword1").value;

        const data = { nome, email, senha };

        fetch("https://localhost:5001/Usuario", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(data)
        })
        .then(response => response.json())
        .then(result => {
            if (result.success) {
                alert("Usuário cadastrado com sucesso!");
                window.location.href = 'index.html'
            } else {
                alert("Erro ao cadastrar usuário: " + result.message);
            }
        })
        .catch(error => {
            console.error("Erro:", error);
            alert("Erro ao cadastrar usuário.");
        });
    });
});
