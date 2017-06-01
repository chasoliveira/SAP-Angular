"use strict";
var router_1 = require('@angular/router');
var home_component_1 = require('./home-component/home.component');
var login_component_1 = require('./login-component/login.component');
var register_component_1 = require('./register-component/register.component');
var product_component_1 = require('./product-component/product.component');
var auth_guard_1 = require('./guards/auth.guard');
var appRoutes = [
    { path: '', component: home_component_1.HomeComponent, canActivate: [auth_guard_1.AuthGuard] },
    { path: 'login', component: login_component_1.LoginComponent },
    { path: 'register', component: register_component_1.RegisterComponent },
    { path: 'product', component: product_component_1.ProductComponent, canActivate: [auth_guard_1.AuthGuard] },
    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map