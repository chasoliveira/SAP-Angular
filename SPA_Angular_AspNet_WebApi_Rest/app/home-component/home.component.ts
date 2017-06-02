import { Component, OnInit } from '@angular/core';
import { Product } from './../models/product';
import { ProductService } from './../services/product.service';

import 'rxjs/add/operator/toPromise';

@Component({
    moduleId: module.id,
    templateUrl: 'home.component.html',
    //providers:[ProductService]
})
export class HomeComponent implements OnInit {
    products: Product[] = [];
    currentUser: any;
    constructor(private productService: ProductService) {
    }

    ngOnInit() {
        let user = JSON.parse(localStorage.getItem('currentUser'));
        if (user)
            this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
        this.loadProducts();
    }
    private loadProducts() {
        this.productService.getAll()
            .then(p => { this.products = p; });
    }
}