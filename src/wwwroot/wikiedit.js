window.wikiEditFunctions = {
    render: function (elementId) {
        let element = document.getElementById(elementId)
        return new SimpleMDE(element);
    }
}