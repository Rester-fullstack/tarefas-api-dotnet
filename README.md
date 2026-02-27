# API de Tarefas com Autenticação JWT

Visão Geral

A aplicação permite gerenciamento de tarefas com autenticação segura utilizando **JSON Web Token (JWT)**.

---

Funcionalidades

✅ CRUD completo de tarefas  
✅ Autenticação e autorização com JWT  
✅ Hash seguro de senha usando BCrypt  
✅ Repository Pattern  
✅ Interface OpenAPI com Scalar UI  
✅ Arquitetura modular para escalabilidade  

---

Tecnologias Utilizadas

- C#
- .NET 9
- Entity Framework Core
- SQL Server
- JWT Authentication
- BCrypt Password Hashing

Desenvolvido utilizando a plataforma de desenvolvimento da :contentReference[oaicite:1]{index=1}.

---

Segurança

O sistema implementa:

- Token JWT para controle de acesso  
- Hash criptográfico de senhas  
- Middleware de autorização  

---

Estrutura do Projeto


Controllers/ → Endpoints da API
Data/ → Contexto do banco
Models/ → Entidades do sistema
Repositories/ → Camada de acesso a dados
Services/ → Regras de negócio


---

Como Executar o Projeto

1. Clone o repositório
 git clone https://github.com/seuusuario/tarefas-api-dotnet.git

3. Restaurar dependências
 dotnet restore
 
4. Executar aplicação
 dotnet run
 
Interface da API

Acesse a documentação interativa:
 http://localhost:5168/scalar/v1

Credenciais de Teste
 Username: admin
 Password: 123456
 
 Autor
 Projeto desenvolvido para portfólio backend.

Licença
 Projeto de uso pessoal.
