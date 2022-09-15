package org.example;

import org.telegram.telegrambots.bots.TelegramLongPollingBot;
import org.telegram.telegrambots.meta.api.methods.send.SendMessage;
import org.telegram.telegrambots.meta.api.objects.Update;
import org.telegram.telegrambots.meta.exceptions.TelegramApiException;


public class EchoBot extends TelegramLongPollingBot {

        @Override
        public String getBotUsername() {
            return "PruebaANbot";
        }

        @Override
        public String getBotToken() {
            return "5617275326:AAHEixdVqscjMEqB8MWumLRfQkSr49eHYk8";
        }


        @Override
        public void onUpdateReceived(Update update) {

            //como sabe el bot que esto se ejecuta con el /start?
            //como se especifican los comandos
            //tengo que hacer una clase por comando?

            //se obtiene el mensaje escrito por el usuario
            final String messageTextReceived = update.getMessage().getText();

            //se obtiene el id del chat del usuario
            final long chatId = update.getMessage().getChatId();

            SendMessage message = procesarMensaje(String.valueOf(chatId), messageTextReceived);

            try{
                execute(message);
            }catch (TelegramApiException e){
                e.printStackTrace();
            }

        }

        private SendMessage procesarMensaje (String chatId, String texto){
            SendMessage message = new SendMessage();
            message.setText("Me has dicho: "+texto);
            message.setChatId(String.valueOf(chatId));

            return message;
        }

    }

