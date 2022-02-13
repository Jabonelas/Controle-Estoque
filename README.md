# Controle-Estoque - C#
Software para controle, gerenciamento e faturamento de estoque para uma loja de materiais de construção.
Sistema desenvolvido somente por experiência , para aplicação dos conhecimento e habilidade até o momento adquiridos.
**
## Tela Inicial
**
![pagina inicial](https://user-images.githubusercontent.com/99104618/153733148-a29450ce-2ef0-4756-9348-0823fa084161.png)

**

## Tela de entrada de Nota Fiscal

**
![Entrada](https://user-images.githubusercontent.com/99104618/153734050-25db7523-cd5a-440b-bbf1-50a7c9ecad44.png)

**Buscar** - Sendo possivel  consultar os itens da NF.

 - [x] Codigo do item.
 - [x] Descrição do Produto.
 - [x] Fornecedor.
 - [x] Quantidade.
 - [x] Unidade de Medida. 
 - [x] Observações.  
 - [x] Valor.
 - [x] Localização.
 - [x] Data de Emissão.
 - [x] Data de Lançamento.
 - [x] Codigo de barra.

**Confirmar** -  Confirmar a entrada da NF no sistema, lançando os itens no estoque.

 **Excluir** - Retirara da NF do sistema, sendo possível apenas quando a quantidade e local for igual ao declarada na NF de entrada, impedindo que gerado saldo fantasma no sistema.


## Tela de Buscar
![busca](https://user-images.githubusercontent.com/99104618/153734038-34829aae-6e3f-4757-949a-07f0428a255c.png)

**Buscar** - Sendo possivel  consultar por codigo do item, informando:

 - [x] Nota Fiscal de entrada.
 - [x] Código do item.
 - [x] Descrição do Produto.
 - [x] Quantidade.
 - [x] Unidade de Medida.
 - [x] Local.
 - [x] Lote.
 - [x] Código de barra.

## Tela de Estoque
![estoque1](https://user-images.githubusercontent.com/99104618/153733984-23daef08-2027-47f5-8b13-5ab25a260f1e.png)

**Buscar** - Sendo possivel  consultar por codigo de barra informando:
 
 - [x] Código de barra.
 - [x] Código do item.
 - [x] Lote.
 - [x] Descrição do Produto.
 - [x] Quantidade.
 - [x] Local.
 - Informando situação da etiqueta se já teve seu saldo parcialmente ou totalmente consumido (faturado).
 
**Confirmar**  - Confirmar a transferência de local, realizando assim a movimentação do estoque.  
Realiza a movimentação para PRODUÇÃO seguindo o FIFO (first  in  first  out) por lote e etiqueta, impedindo que seja feita a transferência de mais de uma etiqueta do mesmo item enquanto ainda possui saldo disponível em PRODUÇÃO.


## Tela de Saída de Nota Fiscal
![Saida](https://user-images.githubusercontent.com/99104618/153734013-786a6129-caeb-4f34-8c9e-de5a7fe6552e.png)

**Buscar** - Sendo possivel  consultar por Nota Fiscal de Saída informando:

 - [x] Nota Fiscal de Saída.
 - [x] Código do item.
 - [x] Descrição do Produto.
 - [x] Quantidade.
 - [x] Unidade de Medida.
 - [x] Observação.
 - [x] Valor.
 - [x] Emissão.
 
  
**Buscar** - Sendo possivel  consultar por Código do item informando:

 - [x] Código do item.
 - [x] Descrição do Produto.
 - [x] Quantidade.
 - [x] Unidade de Medida.
 - [x] Observação.
 - [x] Valor.
 - Informa se o saldo da etiqueta é insuficiente gerar a NF de Saída com a quantidade requisitada e informa a quantidade restante e se esta disponivel em PRODUÇÃO.

**Adicionar**  - Adiciona mais de um item na mesma Nofa Fiscal,  

**Confirmar**  - Confirmar a Nota Fiscal de Saída, retirando o saldo do sistema. 

**Cancelar**  - Cancela Nota Fiscal de Saída retornando o saldo para o sistema. 

