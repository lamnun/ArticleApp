window.clipboardCopy = {
    copyText: function (text) {
        navigator.clipboard.writeText(text).then(function () {
            alert("링크를 클립보드에 복사했습니다.");
        })
            .catch(function (error) {
                alert(error);
            });
    }
};