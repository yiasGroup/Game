var yias = {};
var jsList = [
     "<script src='js/jquery-2.0.3.min.js' type='text/javascript'></script>",
     "<script src='js/jquery.cookie.js' type='text/javascript'></script>",
     "<script src='js/yias.ajax.js' type='text/javascript'></script>"
];

var cssList = [];

function GetHeadJs() {
    for (var i = 0; i < jsList.length; i++) {
        document.write(jsList[i]);
    }
}
function getd(id) {
    return document.getElementById(id);
}
function toJSON(o) {
    var f = function (n) {
        return n < 10 ? '0' + n : n;
    },
    meta = {    // table of character substitutions
        '\b': '\\b',
        '\t': '\\t',
        '\n': '\\n',
        '\f': '\\f',
        '\r': '\\r',
        '"': '\\"',
        '\\': '\\\\'
    },
    escapable = /[\\\"\x00-\x1f\x7f-\x9f\u00ad\u0600-\u0604\u070f\u17b4\u17b5\u200c-\u200f\u2028-\u202f\u2060-\u206f\ufeff\ufff0-\uffff]/g,
    quote = function (value) {
        escapable.lastIndex = 0;
        return escapable.test(value) ?
            '"' + value.replace(escapable, function (a) {
                var c = meta[a];
                return typeof c === 'string' ? c :
                    '\\u' + ('0000' + a.charCodeAt(0).toString(16)).slice(-4);
            }) + '"' :
            '"' + value + '"';
    };
    if (o === null) return 'null';
    var type = typeof o;
    if (type === 'undefined') return undefined;
    if (type === 'string') return quote(o);
    if (type === 'number' || type === 'boolean') return '' + o;
    if (type === 'object') {
        if (o.constructor === Date) {
            return isFinite(o.valueOf()) ?
               '"' + o.getFullYear() + '-' +
             f(o.getMonth() + 1) + '-' +
             f(o.getDate()) + ' ' +
             f(o.getHours()) + ':' +
             f(o.getMinutes()) + ':' +
             f(o.getSeconds()) + '"' : null;
        }
        if (typeof o.toJSON === 'function') {
            return toJSON(o.toJSON());
        }
        var pairs = [];
        if (o.constructor === Array) {
            for (var i = 0, l = o.length; i < l; i++) {
                pairs.push(toJSON(o[i]) || 'null');
            }
            return '[' + pairs.join(',') + ']';
        }
        var name, val;
        for (var k in o) {
            type = typeof k;
            if (type === 'number') {
                name = '"' + k + '"';
            } else if (type === 'string') {
                name = quote(k);
            } else {
                continue;
            }
            type = typeof o[k];
            if (type === 'function' || type === 'undefined') {
                continue;
            }
            val = toJSON(o[k]);
            pairs.push(name + ':' + val);
        }
        return '{' + pairs.join(',') + '}';
    }
};