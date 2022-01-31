import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-eventos',
    templateUrl: './eventos.component.html',
    styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent implements OnInit {

    public eventos: any = [
        {
            Tema: 'Angular',
            Local: 'São Paulo'
        },
        {
            Tema: 'React',
            Local: 'Rio de Janeiro'
        },
        {
            Tema: 'Vue',
            Local: 'Mogi das Cruzes'
        }
    ];


    constructor() {}

    ngOnInit(): void {}
}
