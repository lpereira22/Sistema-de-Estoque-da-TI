# 📦 Sistema de Estoque de TI

Este projeto representa um sistema de controle de estoque voltado para materiais de TI, permitindo gerenciar entrada, saída e monitoramento de itens de forma simples e eficiente.

---

## 🛠️ Tecnologias utilizadas

- 💻 C# com Windows Forms  
- 🗄️ Banco de dados MySQL  
- 🔗 Integração via MySql.Data  

---

## 🚀 Funcionalidades

- Cadastro de produtos  
- Controle de entrada e saída  
- Contagem automática de itens  
- Monitoramento de estoque mínimo  
- Atualização em tempo real (Timer ou botão)  

---

## 🖼️ Imagens do sistema

### 🔹 Tela principal
<img width="858" height="510" alt="image" src="https://github.com/user-attachments/assets/dedd06c8-6c23-4870-86a5-95c3fd4205cc" />


---

### 🔹 Cadastro de produtos
<img width="855" height="511" alt="image" src="https://github.com/user-attachments/assets/f7789fe1-dbf7-42d6-9c18-89789f3cdf26" />


---

### 🔹 Controle de estoque
<img width="855" height="511" alt="image" src="https://github.com/user-attachments/assets/580b136e-9f5d-4acd-be8e-9868886d7be7" />


---

## 🧠 Como foi desenvolvido

O sistema foi desenvolvido utilizando **Windows Forms**, uma tecnologia da plataforma .NET para criação de aplicações desktop com interface gráfica.

A linguagem utilizada foi o **C#**, responsável por toda a lógica da aplicação, incluindo:

- Manipulação de eventos (cliques, carregamento de tela, etc.)
- Atualização dinâmica de dados na interface
- Integração com o banco de dados

---

## 🗄️ Banco de Dados

Foi utilizado o **MySQL** para armazenamento dos dados.

### Exemplo de estrutura da tabela `produtos`:

- id  
- nome  
- categoria  
- quantidade  
- quantidade_minima  
- data_criacao  

### Exemplos de consultas utilizadas:

```sql
SELECT COUNT(*) FROM produtos;

SELECT COUNT(*) FROM produtos WHERE quantidade < quantidade_minima;

SELECT COUNT(DISTINCT categoria) FROM produtos;
