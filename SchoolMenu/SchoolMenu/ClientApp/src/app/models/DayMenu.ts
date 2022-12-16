export class DayMenu {
    id: string;
    weekName: string;

    public constructor(id: string, weekName: string) {
        this.id = id;
        this.weekName = weekName;
    }
}

export class DayMenuInsert {
    menuId: string;
    weekDay: number;

    public constructor(menuId: string, weekDay: number) {
        this.menuId = menuId;
        this.weekDay = weekDay;
    }
}