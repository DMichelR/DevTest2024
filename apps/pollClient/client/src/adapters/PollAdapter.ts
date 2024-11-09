import { OptionModel } from "@/models/OptionModel"
import { PollModel } from "@/models/PollModel"

export type PollAdapter = {
    id: string,
    name: string,
    options: OptionModel[]
}

export function toPoll(adapter: PollAdapter): PollModel {
    return {
        id: adapter.id,
        name: adapter.name,
        options: adapter.options
    }
}