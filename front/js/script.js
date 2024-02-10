const menorValor = 1
const maiorValor = 1000
const numeroSorteado = gerarNumero()


function redirecionarParaLogin() {
    // Redirecionar para a página de login
    window.location.href = 'login.html';
}

function redirecionarParaUser() {
    window.location.href = 'user.html';
}


function mudarCursor() {
    // Mudar o cursor do mouse para 'pointer'
    document.getElementById('LoginHelp').style.cursor = 'pointer';
}

function mudarCursorLogin() {
    // Mudar o cursor do mouse para 'pointer'
    document.getElementById('CadastroHelp').style.cursor = 'pointer';
}

function redirecionarParaCadastro() {
    // Redirecionar para a página de login
    window.location.href = 'cadastro.html';
}

function gerarNumero(){
    return parseInt(Math.random() * maiorValor + 1)
}

console.log(numeroSorteado)

const elementoMenorValor = document.getElementById('menor-valor')
elementoMenorValor.innerHTML = menorValor
const elementoMaiorValor = document.getElementById('maior-valor')
elementoMaiorValor.innerHTML = maiorValor

