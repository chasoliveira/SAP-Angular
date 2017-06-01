"use strict";
var router_1 = require('@angular/router');
var app_component_1 = require('./app.component');
var product_component_1 = require('./product-component/product.component');
var appRouters = [
    {
        path: '',
        redirectTo: '/',
        pathMatch: 'full'
    },
    {
        path: 'product',
        component: product_component_1.ProductComponent
    }
];
exports.routing = router_1.RouterModule.forRoot(appRouters);
exports.routertedComponents = [app_component_1.AppComponent, product_component_1.ProductComponent];
//# sourceMappingURL=app-routing.js.map