$(document).ready(function(){
    loadProperties('main', '../lang/');
});

function loadProperties(name, path, lang){
    var lang = lang || navigator.language;
    jQuery.i18n.properties({
        name:name,
        path:path,
        mode:'map',
        language: lang,
        callback: function() {
            $("[data-localize]").each(function() {
                var elem = $(this),
                    localizedValue = jQuery.i18n.map[elem.data("localize")];
                if (elem.is("input[type=text]") || elem.is("input[type=password]") || elem.is("input[type=email]")) {
                    elem.attr("placeholder", localizedValue);
                } else if (elem.is("input[type=button]") || elem.is("input[type=submit]")) {
                    elem.attr("value", localizedValue);
                } else {
                    elem.text(localizedValue);
                }
            });
        }
    });
}
