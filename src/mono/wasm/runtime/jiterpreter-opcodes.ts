// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Keep this file in sync with mintops.def. The order and values need to match exactly.

export const enum MintOpArgType {
	MintOpNoArgs = 0,
	MintOpShortInt,
	MintOpUShortInt,
	MintOpInt,
	MintOpLongInt,
	MintOpFloat,
	MintOpDouble,
	MintOpBranch,
	MintOpShortBranch,
	MintOpSwitch,
	MintOpMethodToken,
	MintOpFieldToken,
	MintOpClassToken,
	MintOpTwoShorts,
	MintOpTwoInts,
	MintOpShortAndInt,
	MintOpShortAndShortBranch,
	MintOpPair2,
	MintOpPair3,
	MintOpPair4
}

export type OpcodeInfoTable = {
    [key: number]: [name: string, length_u16: number, dregs: number, sregs: number, optype: MintOpArgType];
}

// Keep this in sync with the wasm spec (but I don't think any changes will impact it),
// Note that prefix opcodes aren't in this enum, since making them write properly is awkward.

export const enum WasmOpcode {
    unreachable = 0x00,
    nop,
    block,
    loop,
    if_,
    else_,

    try_ = 0x06,
    catch_,
    catch_all = 0x19,
    throw_ = 0x08,
    rethrow_ = 0x09,

    end = 0x0b,
    br,
    br_if,
    br_table,
    return_,
    call,
    call_indirect,

    drop = 0x1a,
    select,

    get_local = 0x20,
    set_local,
    tee_local,
    get_global,
    set_global,

    i32_load = 0x28,
    i64_load,
    f32_load,
    f64_load,
    i32_load8_s,
    i32_load8_u,
    i32_load16_s,
    i32_load16_u,
    i64_load8_s,
    i64_load8_u,
    i64_load16_s,
    i64_load16_u,
    i64_load32_s,
    i64_load32_u,
    i32_store,
    i64_store,
    f32_store,
    f64_store,
    i32_store8,
    i32_store16,
    i64_store8,
    i64_store16,
    i64_store32,
    current_memory,
    grow_memory,

    i32_const = 0x41,
    i64_const,
    f32_const,
    f64_const,

    i32_eqz = 0x45,
    i32_eq,
    i32_ne,
    i32_lt_s,
    i32_lt_u,
    i32_gt_s,
    i32_gt_u,
    i32_le_s,
    i32_le_u,
    i32_ge_s,
    i32_ge_u,
    i64_eqz,
    i64_eq,
    i64_ne,
    i64_lt_s,
    i64_lt_u,
    i64_gt_s,
    i64_gt_u,
    i64_le_s,
    i64_le_u,
    i64_ge_s,
    i64_ge_u,
    f32_eq,
    f32_ne,
    f32_lt,
    f32_gt,
    f32_le,
    f32_ge,
    f64_eq,
    f64_ne,
    f64_lt,
    f64_gt,
    f64_le,
    f64_ge,

    i32_clz = 0x67,
    i32_ctz,
    i32_popcnt,
    i32_add,
    i32_sub,
    i32_mul,
    i32_div_s,
    i32_div_u,
    i32_rem_s,
    i32_rem_u,
    i32_and,
    i32_or,
    i32_xor,
    i32_shl,
    i32_shr_s,
    i32_shr_u,
    i32_rotl,
    i32_rotr,
    i64_clz,
    i64_ctz,
    i64_popcnt,
    i64_add,
    i64_sub,
    i64_mul,
    i64_div_s,
    i64_div_u,
    i64_rem_s,
    i64_rem_u,
    i64_and,
    i64_or,
    i64_xor,
    i64_shl,
    i64_shr_s,
    i64_shr_u,
    i64_rotl,
    i64_rotr,
    f32_abs,
    f32_neg,
    f32_ceil,
    f32_floor,
    f32_trunc,
    f32_nearest,
    f32_sqrt,
    f32_add,
    f32_sub,
    f32_mul,
    f32_div,
    f32_min,
    f32_max,
    f32_copysign,
    f64_abs,
    f64_neg,
    f64_ceil,
    f64_floor,
    f64_trunc,
    f64_nearest,
    f64_sqrt,
    f64_add,
    f64_sub,
    f64_mul,
    f64_div,
    f64_min,
    f64_max,
    f64_copysign,

    i32_wrap_i64 = 0xa7,
    i32_trunc_s_f32,
    i32_trunc_u_f32,
    i32_trunc_s_f64,
    i32_trunc_u_f64,
    i64_extend_s_i32,
    i64_extend_u_i32,
    i64_trunc_s_f32,
    i64_trunc_u_f32,
    i64_trunc_s_f64,
    i64_trunc_u_f64,
    f32_convert_s_i32,
    f32_convert_u_i32,
    f32_convert_s_i64,
    f32_convert_u_i64,
    f32_demote_f64,
    f64_convert_s_i32,
    f64_convert_u_i32,
    f64_convert_s_i64,
    f64_convert_u_i64,
    f64_promote_f32,

    i32_reinterpret_f32 = 0xbc,
    i64_reinterpret_f64,
    f32_reinterpret_i32,
    f64_reinterpret_i64,

    i32_extend_8_s = 0xc0,
    i32_extend_16_s,
    i64_extend_8_s,
    i64_extend_16_s,
    i64_extend_32_s,

    PREFIX_sat = 0xfc,
    PREFIX_atomic = 0xfe
}
