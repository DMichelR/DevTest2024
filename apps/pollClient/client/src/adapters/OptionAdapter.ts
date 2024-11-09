import { OptionModel } from "@/models/OptionModel"

export type OptionAdapter = {
    id: string,
    name: string,
}

export function toOption(adapter: OptionAdapter): OptionModel {
    return {
        id: adapter.id,
        name: adapter.id,
        votes: 0,
    }
}