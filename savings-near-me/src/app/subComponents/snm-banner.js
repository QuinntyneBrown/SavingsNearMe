ngX.Component({
    selector: "snm-banner",
    styles: [
        ".snm-banner {",
        "font-family: Arial;",
        "background-color: white; padding: 10px; height: 200px;",
        "}",
        ".snm-banner .logo { float:left; position:relative; width:200px; }",
        ".snm-banner .nav { float:right; position:relative; }",
        ".snm-banner .clear { clear:both; }"
    ].join(" \n "),
    template: [
        "<div class='snm-banner'>",
        "<div class='logo'><img src='assets/images/logo.png'></img></div>",
        "<div class='nav'>",
        "<a href='#/'>Home</a>",
        "<a href='#/coupons'>Coupons</a>",
        "<a href='#/login'>Login</a>",
        "</div>",
        "<div class='clear'></div>",
        "</div>"
    ].join(" ")
});
//# sourceMappingURL=snm-banner.js.map