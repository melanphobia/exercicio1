let numeros = ['10','3','5','2','1','6']

function inserir(callback) {
    let inputNumero = document.getElementsByTagName('input')[0]
    numeros.push(parseInt(inputNumero.value))

    inputNumero.value = ''
    inputNumero.focus()
    callback(0)
}

function listar(element) {
    let x = 0
    let ondeColocar = document.getElementsByTagName('span')[element]
    let itens = ''
    while (x < numeros.length) {
        itens += `${numeros[x]}, `
        x++
    }
    itens = itens.substring(0, itens.length - 2)

    ondeColocar.innerHTML = itens
}

function mostrarArrayOrdenado(callback) {
    let trocou = true
    while (trocou) {
        trocou = false
        for (let i = 0; i < numeros.length - 1; i++) {
            if (numeros[i] > numeros[i + 1]) {
                let temp = numeros[i + 1]
                numeros[i + 1] = numeros[i]
                numeros[i] = temp
                trocou = true
            }
        }
    }
    callback(1)
}

function pesquisar(numero){
    for(let i = 0; i < numeros.length; i++){
        if(numeros[i] == numero){
            return i;
        }
    }
    return -1;
}

function mostarPosicao(){
    let numeroProcurado = document.getElementById('numeroProcurado')
    document.getElementById('resultado').value = pesquisar(numeroProcurado.value)
}

function excluir(){
    let numeroExcluir = document.getElementById('numeroExcluir')
    let posicao = pesquisar(numeroExcluir.value)
    console.log(numeros)
    numeros.splice(posicao,1)
    console.log(numeros)
}