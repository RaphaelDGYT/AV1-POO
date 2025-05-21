# AV1-POO
## Problema:
Pedro está trabalhando em uma aplicação de chatbots e precisa enviar mensagens para diversos canais de comunicação (whatsapp, telegram, facebook, instagram).
As mensagens podem ter formatos distintos: texto, vídeo, fotos, arquivos.

Crie uma estrutura de código com orientação a objetos que possa enviar mensagem no formato correto para o canal selecionado.

**Canais:**
- *WhatsApp/Telegram - Número de telefone*
- *Facebook/Instagram/Telegram - Usuário*

**Mensagens:**
- *Texto: Mensagem, Data Envio*
- *Vídeo: Mensagem, arquivo, formato, duração*
- *Foto: Mensagem, arquivo, formato*
- *Arquivo: Mensagem, arquivo, formato*

Obs.: O envio das mensagens é simulado. Porde apenas imprimir no console os dados.

## Barema de correção:
(2,5) Implementação de todas os canais<br>
(1,5 - cada) Implementação de cada tipo de mensagem<br>
(1,5) Utilização dos conceitos de POO (Herança, encapsulamento, Polimorfismo)<br>

## Minha Resolução:

Para resolver o problema, utilizei os principais conceitos de Programação Orientada a Objetos (POO): herança, encapsulamento e polimorfismo.

### Estrutura de Classes

- **Classe abstrata `Canal`**: Define a interface comum para todos os canais de comunicação, com métodos para envio de mensagens.
- **Subclasses de `Canal`**: Implementei classes específicas para cada canal (`WhatsApp`, `Telegram`, `Facebook`, `Instagram`). Cada uma trata os dados de contato conforme necessário (número de telefone ou usuário).
- **Classe abstrata `Mensagem`**: Serve como base para os diferentes tipos de mensagens, armazenando informações comuns como o texto da mensagem e a data de envio.
- **Subclasses de `Mensagem`**: Criei classes para cada tipo de mensagem (`MensagemTexto`, `MensagemVideo`, `MensagemFoto`, `MensagemArquivo`), cada uma com atributos específicos (como arquivo, formato, duração, etc).

### Encapsulamento

Os atributos das classes são privados ou protegidos, e o acesso é feito por meio de métodos públicos (getters/setters), garantindo o encapsulamento dos dados.

### Herança e Polimorfismo

Utilizei herança para evitar repetição de código entre os canais e entre os tipos de mensagens. O polimorfismo é aplicado no método de envio, permitindo que cada canal e cada tipo de mensagem implemente seu próprio comportamento de envio.

### Simulação do Envio

O envio das mensagens é simulado por meio de impressões no console, mostrando todos os dados relevantes de cada mensagem e canal.

### Como testar o projeto?

Para testar o projeto, é necessário ter o .NET SDK instalado em sua máquina.  
Após a instalação, navegue até a pasta do projeto pelo terminal e execute o comando abaixo para rodar a aplicação:

```powershell
dotnet run
```
O programa irá simular o envio das mensagens, exibindo as informações no console.

### Exemplo de Uso

```csharp
# Exemplo de envio de mensagem de texto pelo WhatsApp
var canal = new WhatsApp("11 999999999");
var mensagem = new Texto("Hello World!");
canal.EnviarMensagem(mensagem);
```