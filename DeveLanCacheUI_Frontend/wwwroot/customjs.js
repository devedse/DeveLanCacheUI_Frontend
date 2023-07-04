window.scrollChatToBottom = () => {
    var chatBox = document.querySelector('.chat-box');
    chatBox.scrollTop = chatBox.scrollHeight;
}

window.themeSwitcher = {
    switchTheme: function (theme) {
        document.documentElement.setAttribute('data-bs-theme', theme);
    },
    getPreferredColorScheme: function () {
        return window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches ? "dark" : "light";
    }
};