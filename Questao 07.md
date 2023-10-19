## Interface

Você está desenvolvendo um sistema de gerenciamento de animais em um zoológico. Diferentes animais têm a capacidade de fazer barulhos característicos. Como você aplicaria interface em C# para garantir que diferentes classes de animais possam implementar o método "FazerBarulho" de maneiras diferentes?

**Por exemplo:**

```csharp
Leao leao = new Leao();
Macaco macaco = new Macaco();

leao.FazerBarulho();
"O leão ruge alto!"
macaco.FazerBarulho();
"O macaco faz sons engraçados"
```