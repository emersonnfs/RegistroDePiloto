# RegistroDePiloto
Cp06Enterprise

## Integrantes 2-TDSR
  
  Abner Rodrigues Ferreira - RM: 93576
  Davi Oliveira Da Silva - RM: 95535
  Emerson Nascimento Figueredo Silva - RM:95199
  Guilherme De Jesus Ferreira - RM: 95542
  João Victor Oliveira Da Silva - RM: 94231

---

## How to Do

### Criar projeto ASP.NET(M.V.C)

### Criação de classe Piloto contendo Enum de Tipo Licença
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/96070d0d-ceee-4636-99e7-3f6bbdc6278b)
  (Escondemos o Input do Id gerado automaticamente pelo projeto, passamos a mensagem de erro aos Inputs que não cumprirem os seus respectivos tipos e utilizamos os display para os campos de Tipo de licença e Data de Expiração da Licença)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/989cd2ae-f3f9-4a32-ba26-9609123e4ad5)
  (Enum de Tipo de Licença de Piloto)

### Criação de Tag Helpers para os botões e de mensagem
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/2b147142-3ebf-4c21-baa5-e5b1749aaa46)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/463e3cb1-63e0-4889-94ae-705b1a47cc5e)

### Criação do pacote Piloto com (Formulário, Cadastrar, Editar e o Index)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/ab6759fa-1930-4d5d-982a-47bda504762d)
  (Capturamos os dados inputados nos determinados campos  se forem validados senão o span mostrará o erro)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/b23065d3-cb81-46fb-adf7-bdceb2ae52b5)
  (O método que chama para o cadastro)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/4eb67867-87a8-4e8e-8e3d-76db89c3c66b)
  (O método que chama para o editar)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/443780ef-3a0c-47ea-b0c1-6ee3e8dee2c5)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/4ef54d77-3247-4cc6-9fd4-f45ffceeee57)
  (O index lista os pilotos com os botões de cadastro e editar e o modal)

### Design de página
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/1ca94f23-be5d-4d4d-86f8-38e597c72a66)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/233b9bdb-83b2-467e-85ee-940105d14ac0)
  (Utilizamos o tema Vapor do Bootswatch, e usamos o datepicker do JQuery-ui para o calendário para facilitar o input da data de expiração da licença do piloto)

### Conexão com o banco de dados
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/e809de45-e76b-4b80-8b6e-e4b1e1e96041)
  (Criamos o DbContext do para o Piloto, utilizamos de EntityFramework da Microsoft e da Oracle para conectar o banco e passamos a String de conexão)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/52385051-2d84-4fca-a730-8f8d8ab335f9)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/55d78d18-8ef3-4c59-aa71-224c62143d60)
  (Utilizamos do pacote do EntityFrameworkCore.Design da Microsoft para fazer os Migrations para gerar a tabela no banco e a ModalBuilder)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/df83cd3e-8156-4bf5-95f4-4622099f40b5)
![image](https://github.com/emersonnfs/RegistroDePiloto/assets/101301360/6ec1c9d2-2887-48ef-ad2a-20a5a37db08e)
  (Criamos os metodos de Listar, Cadastrar, Editar e Remover para comunicar como banco de dados onde gerenciamos a comunicação com banco de dados)

---

## Video projeto em execução



