import { TileCategory } from "../models/tile-category";

export class TileConsts {
    public static Categories: TileCategory[] = [
        {
            categoryName: 'Passport Data',
            tiles: [
                { id: 1, viewFor: 'passportNameSearch', description: 'Search By Name', permissionId: 1, route: '/passport', tileIcon: 'fa fa-user' },
                { id: 2, viewFor: 'passportIdSearch', description: 'Search By ID', permissionId: 0, route: '/passport/id', tileIcon: 'fa fa-id-card' },

            ],
            tileColorClass: 'card-body tile-linear-bg-success text-white justify-content-center align-self-center align-items-center',
            permissionId: 1,
        },
        {
            categoryName: 'VTA Data',
            tiles: [
                { id: 1, viewFor: 'vtaNameSearch', description: 'Search By Name', permissionId: 1, route: '/vta', tileIcon: 'fa fa-user' },
                { id: 2, viewFor: 'vtaIdSearch', description: 'Search By ID', permissionId: 0, route: '/vta/id', tileIcon: 'fa fa-id-card' },
            ],
            tileColorClass: 'card-body tile-linear-bg-primary text-white justify-content-center align-self-center align-items-center',
            permissionId: 0,
        },
        {
            categoryName: 'PBI Data',
            tiles: [
                { id: 1, viewFor: 'pbiNameSearch', description: 'Search By Name', permissionId: 1, route: '/', tileIcon: 'fa fa-user' },
                { id: 2, viewFor: 'pbiIdSearch', description: 'Search By ID', permissionId: 0, route: '/', tileIcon: 'fa fa-id-card' },
            ],
            tileColorClass: 'card-body tile-linear-bg-warning text-white justify-content-center align-self-center align-items-center',
            permissionId: 2,
        }
    ]
}