window.clipboardCopy = {
    copyText: function (text) {
        navigator.clipboard.writeText(text).then(function () {
            alert("복사!");
        })
            .catch(function (error) {
                alert(error);
            });
    }
};