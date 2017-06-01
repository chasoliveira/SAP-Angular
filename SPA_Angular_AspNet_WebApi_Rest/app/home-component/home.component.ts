import { Component } from '@angular/core';
import { Product } from './../models/product';
import { ProductService } from './../services/product.service';

@Component({
    moduleId: module.id,
    templateUrl: 'home.component.html'
})
export class HomeComponent {
    products: Product[] = [];

    constructor(private productService: ProductService) {
    }

    ngOnInit() {
        this.loadProducts();
    }
    private loadProducts() {
        this.productService.get()
            .then(p => { this.products = p; });
    }
}