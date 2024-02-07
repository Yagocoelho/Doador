function createDoador(){
    const doadorNome = document.getElementById('name').value; /*criar variavel para receber os valores inseridos na sala*/
    const cidade = document.getElementById('city').value;
    const estado = document.getElementById('state').value;
    const email = document.getElementById('email').value;
    const telefone = document.getElementById('telephone').value;
    const cep = document.getElementById('zipcode').value;

    const data={
        doadorNome: doadorNome,/*assimilar nossas varivaeis do front com o back*/
        cidade: cidade,
        estado: estado,
        email: email,
        telefone: telefone,
        cep: cep,

    }
    

fetch("https://localhost:7024/api/Doador/CadastrarDoador", {
    method:'POST',
    headers: {
        'Content-Type':'application/json'
    },
    body: JSON.stringify(data)
}).then(response =>{
    if (!response.ok){
        alert("Erro ao criar Doador");
    }
    alert("Doador criada com sucesso!");
    window.location.href = '../index.html';
})
}