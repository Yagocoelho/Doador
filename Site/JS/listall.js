document.addEventListener("DOMContentLoaded", function(){
    const doadorlista = document.getElementById('doador-lista');

    function renderTable(data){
        
        doadorlista.innerHTML =  "";

        data.forEach(doador =>{
            const row = document.createElement('tr');

            row.innerHTML= `
            <td>${doador.doadorId}</td>
            <td>${doador.doadorNome}</td>
            <td>${doador.cidade}</td>
            <td>${doador.estado}</td>
            <td>${doador.telefone}</td>
            <td>${doador.email}</td>
            <td>${doador.cep}</td>
            <td><button${id="TelaUpdate"}>Editar</button></td>
            <td> <button>Excluir</button>
            </td>
            `
            doadorlista.appendChild(row)
        })
    }
    function feachDoadores(){
        fetch("https://localhost:7024/api/Doador/BuscarDoadores")
        .then(response => response.json())
        .then(data => renderTable(data))
        .catch(error => console.error('Erro ao buscar dados da Api'))
    }
    feachDoadores();
})

function AbrirTelaUpdte(){
    window.location.href='..pages/update.html'
}
function AbrirTelaCreate(){
    window.location.href='../pages/create.html'
}
function AbrirTelaHome(){
    window.location.href='../pages/index.html'
}