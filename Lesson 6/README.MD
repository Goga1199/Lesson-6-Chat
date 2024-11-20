# CSharpNetApp

## Урок 6. Тестирование приложений: test driven development

### Задание

Продумайте, как можно протестировать код клиента по аналогии с кодом сервера.

### Решение

Добавлены тесты для Message, UdpMessageSource, ChatDBResource, Server и Client. 
Использован пакет Moq для мокирования ChatDBResource и собственные Mock-классы 
для мокирования IMessageSource.
