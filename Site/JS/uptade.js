function atualizarPessoa(){
    var doadorNome = doadorNome('Name').value;
    var cidade = cidade('city').value;
    var estado = estado('state').value;
    var email = email('email').value;
    var telefone= telefone('telephone').value;
    var cep = cep('zipcode').value;

    const data={
        doadorNome: doadorNome,
        cidade: cidade,
        estado: estado,
        email: email,
        telefone: telefone,
        cep: cep,
    }
    

fetch("https://localhost:7070/api/Pessoa/update/{pessoaId}/{primeiroNome}", {
    method:'PUT',
}).then(response =>{
    if (!response.ok){
        alert("Erro ao atualizar doador");
    }
    alert("doador atualizada com sucesso!");
    window.location.href = '../index.html';
})
}
