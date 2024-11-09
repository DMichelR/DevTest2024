import { OptionModel } from "./OptionModel"

export type PollModel = {
    id: string,
    name: string,
    options: OptionModel[]
}