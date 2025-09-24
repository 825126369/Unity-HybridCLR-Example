using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"MainScripts.dll",
		"Unity.Burst.dll",
		"Unity.Collections.dll",
		"Unity.Entities.Hybrid.dll",
		"Unity.Entities.dll",
		"UnityEngine.CoreModule.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// SingleTonMonoBehaviour<object>
	// System.Action<object>
	// System.ByReference<AttackComponent>
	// System.ByReference<AudioReference>
	// System.ByReference<AudioSourceData>
	// System.ByReference<GameObjectCData>
	// System.ByReference<LinkedEntityComponent>
	// System.ByReference<PlayAudioRequest>
	// System.ByReference<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// System.ByReference<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// System.ByReference<PokerAnimationCData2>
	// System.ByReference<PokerAnimationCData>
	// System.ByReference<PokerItemCData>
	// System.ByReference<PokerPoolCData>
	// System.ByReference<PokerSystemSingleton>
	// System.ByReference<PokerTimerRemoveCData>
	// System.ByReference<SpriteRendererCData>
	// System.ByReference<StartDoAniEvent>
	// System.ByReference<Unity.Entities.BakerDebugState.DebugState>
	// System.ByReference<Unity.Entities.BakerDebugState.EntityComponentPair>
	// System.ByReference<Unity.Entities.ChunkIndex>
	// System.ByReference<Unity.Entities.ComponentType>
	// System.ByReference<Unity.Entities.Entity>
	// System.ByReference<Unity.Entities.LinkedEntityGroup>
	// System.ByReference<Unity.Entities.TypeIndex>
	// System.ByReference<Unity.Mathematics.float3>
	// System.ByReference<Unity.Transforms.LocalTransform>
	// System.ByReference<Unity.Transforms.Parent>
	// System.ByReference<int>
	// System.Collections.Generic.Comparer<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>>
	// System.Collections.Generic.Comparer<Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>>
	// System.Collections.Generic.EqualityComparer<Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<System.ValueTuple<Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AttackComponent>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AudioReference>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<GameObjectCData>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PlayAudioRequest>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<AudioSourceData>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<LinkedEntityComponent>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerItemCData>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerItemCData>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerPoolCData>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<StartDoAniEvent>>>
	// System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<AudioSourceData>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<LinkedEntityComponent>>>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.ObjectComparer<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>>
	// System.Collections.Generic.ObjectComparer<Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>>
	// System.Collections.Generic.ObjectEqualityComparer<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>>
	// System.Collections.Generic.ObjectEqualityComparer<Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.IEquatable<Unity.Entities.BakerDebugState.EntityComponentPair>
	// System.IEquatable<Unity.Entities.Entity>
	// System.IEquatable<int>
	// System.ReadOnlySpan<AttackComponent>
	// System.ReadOnlySpan<AudioReference>
	// System.ReadOnlySpan<AudioSourceData>
	// System.ReadOnlySpan<GameObjectCData>
	// System.ReadOnlySpan<LinkedEntityComponent>
	// System.ReadOnlySpan<PlayAudioRequest>
	// System.ReadOnlySpan<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// System.ReadOnlySpan<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// System.ReadOnlySpan<PokerAnimationCData2>
	// System.ReadOnlySpan<PokerAnimationCData>
	// System.ReadOnlySpan<PokerItemCData>
	// System.ReadOnlySpan<PokerPoolCData>
	// System.ReadOnlySpan<PokerSystemSingleton>
	// System.ReadOnlySpan<PokerTimerRemoveCData>
	// System.ReadOnlySpan<SpriteRendererCData>
	// System.ReadOnlySpan<StartDoAniEvent>
	// System.ReadOnlySpan<Unity.Entities.BakerDebugState.DebugState>
	// System.ReadOnlySpan<Unity.Entities.BakerDebugState.EntityComponentPair>
	// System.ReadOnlySpan<Unity.Entities.ChunkIndex>
	// System.ReadOnlySpan<Unity.Entities.ComponentType>
	// System.ReadOnlySpan<Unity.Entities.Entity>
	// System.ReadOnlySpan<Unity.Entities.LinkedEntityGroup>
	// System.ReadOnlySpan<Unity.Entities.TypeIndex>
	// System.ReadOnlySpan<Unity.Mathematics.float3>
	// System.ReadOnlySpan<Unity.Transforms.LocalTransform>
	// System.ReadOnlySpan<Unity.Transforms.Parent>
	// System.ReadOnlySpan<int>
	// System.Span<AttackComponent>
	// System.Span<AudioReference>
	// System.Span<AudioSourceData>
	// System.Span<GameObjectCData>
	// System.Span<LinkedEntityComponent>
	// System.Span<PlayAudioRequest>
	// System.Span<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// System.Span<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// System.Span<PokerAnimationCData2>
	// System.Span<PokerAnimationCData>
	// System.Span<PokerItemCData>
	// System.Span<PokerPoolCData>
	// System.Span<PokerSystemSingleton>
	// System.Span<PokerTimerRemoveCData>
	// System.Span<SpriteRendererCData>
	// System.Span<StartDoAniEvent>
	// System.Span<Unity.Entities.BakerDebugState.DebugState>
	// System.Span<Unity.Entities.BakerDebugState.EntityComponentPair>
	// System.Span<Unity.Entities.ChunkIndex>
	// System.Span<Unity.Entities.ComponentType>
	// System.Span<Unity.Entities.Entity>
	// System.Span<Unity.Entities.LinkedEntityGroup>
	// System.Span<Unity.Entities.TypeIndex>
	// System.Span<Unity.Mathematics.float3>
	// System.Span<Unity.Transforms.LocalTransform>
	// System.Span<Unity.Transforms.Parent>
	// System.Span<int>
	// System.ValueTuple<Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>>
	// Unity.Burst.SharedStatic<System.IntPtr>
	// Unity.Burst.SharedStatic<Unity.Entities.TypeIndex>
	// Unity.Collections.KVPair<int,Unity.Collections.NativeList<Unity.Entities.Entity>>
	// Unity.Collections.LowLevel.Unsafe.HashMapHelper.Enumerator<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.HashMapHelper.Enumerator<int>
	// Unity.Collections.LowLevel.Unsafe.HashMapHelper<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.HashMapHelper<int>
	// Unity.Collections.LowLevel.Unsafe.UnsafeHashSet.ReadOnly<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Entities.ChunkIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Entities.ComponentType>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Entities.TypeIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Entities.ChunkIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Entities.ComponentType>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Entities.TypeIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ReadOnly<Unity.Entities.ChunkIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ReadOnly<Unity.Entities.ComponentType>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ReadOnly<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList.ReadOnly<Unity.Entities.TypeIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Entities.ChunkIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Entities.ComponentType>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Entities.Entity>
	// Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Entities.TypeIndex>
	// Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ReadOnly<Unity.Entities.BakerDebugState.EntityComponentPair,Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<Unity.Entities.BakerDebugState.EntityComponentPair,Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapBase<Unity.Entities.BakerDebugState.EntityComponentPair,Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.NativeArray.Enumerator<AttackComponent>
	// Unity.Collections.NativeArray.Enumerator<AudioReference>
	// Unity.Collections.NativeArray.Enumerator<AudioSourceData>
	// Unity.Collections.NativeArray.Enumerator<GameObjectCData>
	// Unity.Collections.NativeArray.Enumerator<LinkedEntityComponent>
	// Unity.Collections.NativeArray.Enumerator<PlayAudioRequest>
	// Unity.Collections.NativeArray.Enumerator<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Collections.NativeArray.Enumerator<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Collections.NativeArray.Enumerator<PokerAnimationCData2>
	// Unity.Collections.NativeArray.Enumerator<PokerAnimationCData>
	// Unity.Collections.NativeArray.Enumerator<PokerItemCData>
	// Unity.Collections.NativeArray.Enumerator<PokerPoolCData>
	// Unity.Collections.NativeArray.Enumerator<PokerSystemSingleton>
	// Unity.Collections.NativeArray.Enumerator<PokerTimerRemoveCData>
	// Unity.Collections.NativeArray.Enumerator<SpriteRendererCData>
	// Unity.Collections.NativeArray.Enumerator<StartDoAniEvent>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.BakerDebugState.EntityComponentPair>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.ChunkIndex>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.ComponentType>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.Entity>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.LinkedEntityGroup>
	// Unity.Collections.NativeArray.Enumerator<Unity.Entities.TypeIndex>
	// Unity.Collections.NativeArray.Enumerator<Unity.Mathematics.float3>
	// Unity.Collections.NativeArray.Enumerator<Unity.Transforms.LocalTransform>
	// Unity.Collections.NativeArray.Enumerator<Unity.Transforms.Parent>
	// Unity.Collections.NativeArray.Enumerator<int>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<AttackComponent>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<AudioReference>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<AudioSourceData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<GameObjectCData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<LinkedEntityComponent>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PlayAudioRequest>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerAnimationCData2>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerAnimationCData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerItemCData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerPoolCData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerSystemSingleton>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<PokerTimerRemoveCData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<SpriteRendererCData>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<StartDoAniEvent>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.BakerDebugState.EntityComponentPair>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.ChunkIndex>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.ComponentType>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.Entity>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.LinkedEntityGroup>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Entities.TypeIndex>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Mathematics.float3>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Transforms.LocalTransform>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<Unity.Transforms.Parent>
	// Unity.Collections.NativeArray.ReadOnly.Enumerator<int>
	// Unity.Collections.NativeArray.ReadOnly<AttackComponent>
	// Unity.Collections.NativeArray.ReadOnly<AudioReference>
	// Unity.Collections.NativeArray.ReadOnly<AudioSourceData>
	// Unity.Collections.NativeArray.ReadOnly<GameObjectCData>
	// Unity.Collections.NativeArray.ReadOnly<LinkedEntityComponent>
	// Unity.Collections.NativeArray.ReadOnly<PlayAudioRequest>
	// Unity.Collections.NativeArray.ReadOnly<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Collections.NativeArray.ReadOnly<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Collections.NativeArray.ReadOnly<PokerAnimationCData2>
	// Unity.Collections.NativeArray.ReadOnly<PokerAnimationCData>
	// Unity.Collections.NativeArray.ReadOnly<PokerItemCData>
	// Unity.Collections.NativeArray.ReadOnly<PokerPoolCData>
	// Unity.Collections.NativeArray.ReadOnly<PokerSystemSingleton>
	// Unity.Collections.NativeArray.ReadOnly<PokerTimerRemoveCData>
	// Unity.Collections.NativeArray.ReadOnly<SpriteRendererCData>
	// Unity.Collections.NativeArray.ReadOnly<StartDoAniEvent>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.BakerDebugState.EntityComponentPair>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.ChunkIndex>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.ComponentType>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.Entity>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.LinkedEntityGroup>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Entities.TypeIndex>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Mathematics.float3>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Transforms.LocalTransform>
	// Unity.Collections.NativeArray.ReadOnly<Unity.Transforms.Parent>
	// Unity.Collections.NativeArray.ReadOnly<int>
	// Unity.Collections.NativeArray<AttackComponent>
	// Unity.Collections.NativeArray<AudioReference>
	// Unity.Collections.NativeArray<AudioSourceData>
	// Unity.Collections.NativeArray<GameObjectCData>
	// Unity.Collections.NativeArray<LinkedEntityComponent>
	// Unity.Collections.NativeArray<PlayAudioRequest>
	// Unity.Collections.NativeArray<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Collections.NativeArray<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Collections.NativeArray<PokerAnimationCData2>
	// Unity.Collections.NativeArray<PokerAnimationCData>
	// Unity.Collections.NativeArray<PokerItemCData>
	// Unity.Collections.NativeArray<PokerPoolCData>
	// Unity.Collections.NativeArray<PokerSystemSingleton>
	// Unity.Collections.NativeArray<PokerTimerRemoveCData>
	// Unity.Collections.NativeArray<SpriteRendererCData>
	// Unity.Collections.NativeArray<StartDoAniEvent>
	// Unity.Collections.NativeArray<Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.NativeArray<Unity.Entities.BakerDebugState.EntityComponentPair>
	// Unity.Collections.NativeArray<Unity.Entities.ChunkIndex>
	// Unity.Collections.NativeArray<Unity.Entities.ComponentType>
	// Unity.Collections.NativeArray<Unity.Entities.Entity>
	// Unity.Collections.NativeArray<Unity.Entities.LinkedEntityGroup>
	// Unity.Collections.NativeArray<Unity.Entities.TypeIndex>
	// Unity.Collections.NativeArray<Unity.Mathematics.float3>
	// Unity.Collections.NativeArray<Unity.Transforms.LocalTransform>
	// Unity.Collections.NativeArray<Unity.Transforms.Parent>
	// Unity.Collections.NativeArray<int>
	// Unity.Collections.NativeHashMap.Enumerator<int,Unity.Collections.NativeList<Unity.Entities.Entity>>
	// Unity.Collections.NativeHashMap.ReadOnly<int,Unity.Collections.NativeList<Unity.Entities.Entity>>
	// Unity.Collections.NativeHashMap<int,Unity.Collections.NativeList<Unity.Entities.Entity>>
	// Unity.Collections.NativeKeyValueArrays<Unity.Entities.BakerDebugState.EntityComponentPair,Unity.Entities.BakerDebugState.DebugState>
	// Unity.Collections.NativeList.ParallelWriter<Unity.Entities.Entity>
	// Unity.Collections.NativeList<Unity.Entities.Entity>
	// Unity.Collections.NativeSlice.Enumerator<Unity.Entities.LinkedEntityGroup>
	// Unity.Collections.NativeSlice<Unity.Entities.LinkedEntityGroup>
	// Unity.Entities.Baker<object>
	// Unity.Entities.ComponentLookup<PokerAnimationCData2>
	// Unity.Entities.ComponentLookup<PokerAnimationCData>
	// Unity.Entities.ComponentLookup<PokerItemCData>
	// Unity.Entities.ComponentLookup<PokerTimerRemoveCData>
	// Unity.Entities.ComponentLookup<SpriteRendererCData>
	// Unity.Entities.ComponentLookup<Unity.Transforms.LocalTransform>
	// Unity.Entities.ComponentLookup<Unity.Transforms.Parent>
	// Unity.Entities.ComponentTypeHandle<AttackComponent>
	// Unity.Entities.ComponentTypeHandle<AudioReference>
	// Unity.Entities.ComponentTypeHandle<AudioSourceData>
	// Unity.Entities.ComponentTypeHandle<GameObjectCData>
	// Unity.Entities.ComponentTypeHandle<LinkedEntityComponent>
	// Unity.Entities.ComponentTypeHandle<PlayAudioRequest>
	// Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Entities.ComponentTypeHandle<PokerAnimationCData2>
	// Unity.Entities.ComponentTypeHandle<PokerItemCData>
	// Unity.Entities.ComponentTypeHandle<PokerPoolCData>
	// Unity.Entities.ComponentTypeHandle<PokerTimerRemoveCData>
	// Unity.Entities.ComponentTypeHandle<SpriteRendererCData>
	// Unity.Entities.ComponentTypeHandle<StartDoAniEvent>
	// Unity.Entities.ComponentTypeHandle<Unity.Transforms.LocalTransform>
	// Unity.Entities.ComponentTypeHandle<object>
	// Unity.Entities.DynamicBuffer<Unity.Entities.LinkedEntityGroup>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AttackComponent>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AudioReference>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<GameObjectCData>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<LinkedEntityComponent>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PlayAudioRequest>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerItemCData>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerPoolCData>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<StartDoAniEvent>
	// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<AudioSourceData>
	// Unity.Entities.JobChunkExtensions.JobChunkProducer.ExecuteJobFunction<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>
	// Unity.Entities.JobChunkExtensions.JobChunkProducer.ExecuteJobFunction<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>
	// Unity.Entities.JobChunkExtensions.JobChunkProducer<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>
	// Unity.Entities.JobChunkExtensions.JobChunkProducer<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AttackComponent>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AudioReference>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<GameObjectCData>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PlayAudioRequest>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<AudioSourceData>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<LinkedEntityComponent>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerItemCData>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerItemCData>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerPoolCData>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<StartDoAniEvent>>
	// Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<AudioSourceData>,Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<LinkedEntityComponent>>
	// Unity.Entities.RefRO<AttackComponent>
	// Unity.Entities.RefRO<AudioReference>
	// Unity.Entities.RefRO<AudioSourceData>
	// Unity.Entities.RefRO<GameObjectCData>
	// Unity.Entities.RefRO<LinkedEntityComponent>
	// Unity.Entities.RefRO<PlayAudioRequest>
	// Unity.Entities.RefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Entities.RefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Entities.RefRO<PokerAnimationCData2>
	// Unity.Entities.RefRO<PokerAnimationCData>
	// Unity.Entities.RefRO<PokerItemCData>
	// Unity.Entities.RefRO<PokerPoolCData>
	// Unity.Entities.RefRO<PokerSystemSingleton>
	// Unity.Entities.RefRO<PokerTimerRemoveCData>
	// Unity.Entities.RefRO<SpriteRendererCData>
	// Unity.Entities.RefRO<StartDoAniEvent>
	// Unity.Entities.RefRO<Unity.Transforms.LocalTransform>
	// Unity.Entities.RefRO<Unity.Transforms.Parent>
	// Unity.Entities.RefRW<AudioSourceData>
	// Unity.Entities.RefRW<PokerAnimationCData2>
	// Unity.Entities.RefRW<PokerAnimationCData>
	// Unity.Entities.RefRW<PokerItemCData>
	// Unity.Entities.RefRW<PokerSystemSingleton>
	// Unity.Entities.RefRW<PokerTimerRemoveCData>
	// Unity.Entities.RefRW<SpriteRendererCData>
	// Unity.Entities.RefRW<Unity.Transforms.LocalTransform>
	// Unity.Entities.RefRW<Unity.Transforms.Parent>
	// Unity.Entities.SystemAPI.ManagedAPI.UnityEngineComponent<object>
	// Unity.Entities.TypeManager.SharedTypeIndex<AttackComponent>
	// Unity.Entities.TypeManager.SharedTypeIndex<AudioPool>
	// Unity.Entities.TypeManager.SharedTypeIndex<AudioReference>
	// Unity.Entities.TypeManager.SharedTypeIndex<AudioSourceData>
	// Unity.Entities.TypeManager.SharedTypeIndex<GameObjectCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<LinkedEntityComponent>
	// Unity.Entities.TypeManager.SharedTypeIndex<PlayAudioRequest>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerAnimationCData2>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerAnimationCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerGoMgrInitFinishEvent>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerItemCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerPoolCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerSystemCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerSystemSingleton>
	// Unity.Entities.TypeManager.SharedTypeIndex<PokerTimerRemoveCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<PoolTag>
	// Unity.Entities.TypeManager.SharedTypeIndex<SpriteRendererCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<StartDoAniEvent>
	// Unity.Entities.TypeManager.SharedTypeIndex<TempSpriteRendererUpdateCData>
	// Unity.Entities.TypeManager.SharedTypeIndex<object>
	// Unity.Entities.UnityObjectRef<object>
	// }}

	public void RefMethods()
	{
		// long Unity.Burst.BurstRuntime.GetHashCode64<object>()
		// Unity.Collections.NativeArray<int> Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>(System.Void*,int,Unity.Collections.Allocator)
		// System.Void* Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<Unity.Entities.JobChunkExtensions.JobChunkWrapper<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>>(Unity.Entities.JobChunkExtensions.JobChunkWrapper<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>&)
		// System.Void* Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<Unity.Entities.JobChunkExtensions.JobChunkWrapper<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>>(Unity.Entities.JobChunkExtensions.JobChunkWrapper<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>&)
		// PokerAnimationCData2& Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AsRef<PokerAnimationCData2>(System.Void*)
		// PokerSystemSingleton& Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AsRef<PokerSystemSingleton>(System.Void*)
		// PokerTimerRemoveCData& Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AsRef<PokerTimerRemoveCData>(System.Void*)
		// Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton& Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AsRef<Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton>(System.Void*)
		// Unity.Transforms.LocalTransform& Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AsRef<Unity.Transforms.LocalTransform>(System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyPtrToStructure<GameObjectCData>(System.Void*,GameObjectCData&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyPtrToStructure<PokerAnimationCData2>(System.Void*,PokerAnimationCData2&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyPtrToStructure<PokerAnimationCData>(System.Void*,PokerAnimationCData&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyPtrToStructure<PoolTag>(System.Void*,PoolTag&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<AudioSourceData>(AudioSourceData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<GameObjectCData>(GameObjectCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<LinkedEntityComponent>(LinkedEntityComponent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PokerAnimationCData>(PokerAnimationCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PokerItemCData>(PokerItemCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PokerPoolCData>(PokerPoolCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PokerTimerRemoveCData>(PokerTimerRemoveCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<PoolTag>(PoolTag&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<SpriteRendererCData>(SpriteRendererCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<Unity.Transforms.LocalTransform>(Unity.Transforms.LocalTransform&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.CopyStructureToPtr<Unity.Transforms.Parent>(Unity.Transforms.Parent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyPtrToStructure<GameObjectCData>(System.Void*,GameObjectCData&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyPtrToStructure<PokerAnimationCData2>(System.Void*,PokerAnimationCData2&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyPtrToStructure<PokerAnimationCData>(System.Void*,PokerAnimationCData&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyPtrToStructure<PoolTag>(System.Void*,PoolTag&)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<AudioSourceData>(AudioSourceData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<GameObjectCData>(GameObjectCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<LinkedEntityComponent>(LinkedEntityComponent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PokerAnimationCData>(PokerAnimationCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PokerItemCData>(PokerItemCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PokerPoolCData>(PokerPoolCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PokerTimerRemoveCData>(PokerTimerRemoveCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<PoolTag>(PoolTag&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<SpriteRendererCData>(SpriteRendererCData&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<Unity.Transforms.LocalTransform>(Unity.Transforms.LocalTransform&,System.Void*)
		// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility.InternalCopyStructureToPtr<Unity.Transforms.Parent>(Unity.Transforms.Parent&,System.Void*)
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<AttackComponent>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<AudioReference>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<AudioSourceData>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<GameObjectCData>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<LinkedEntityComponent>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<PlayAudioRequest>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<PokerItemCData>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<PokerPoolCData>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<PokerTimerRemoveCData>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<SpriteRendererCData>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<StartDoAniEvent>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<Unity.Transforms.LocalTransform>()
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<Unity.Transforms.Parent>()
		// System.Void* Unity.Entities.ArchetypeChunk.GetRequiredComponentDataPtrRW<PokerAnimationCData2>(Unity.Entities.ComponentTypeHandle<PokerAnimationCData2>&)
		// System.Void* Unity.Entities.ArchetypeChunk.GetRequiredComponentDataPtrRW<PokerTimerRemoveCData>(Unity.Entities.ComponentTypeHandle<PokerTimerRemoveCData>&)
		// System.Void* Unity.Entities.ArchetypeChunk.GetRequiredComponentDataPtrRW<Unity.Transforms.LocalTransform>(Unity.Entities.ComponentTypeHandle<Unity.Transforms.LocalTransform>&)
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<AttackComponent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<AudioReference>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<AudioSourceData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<GameObjectCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<LinkedEntityComponent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PlayAudioRequest>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerAnimationCData2>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerAnimationCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerItemCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerPoolCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<PokerTimerRemoveCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<SpriteRendererCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<StartDoAniEvent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<Unity.Transforms.LocalTransform>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadOnly<Unity.Transforms.Parent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<AttackComponent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<AudioReference>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<AudioSourceData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<GameObjectCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<LinkedEntityComponent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PlayAudioRequest>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerAnimationCData2>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerAnimationCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerItemCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerPoolCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PokerTimerRemoveCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<PoolTag>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<SpriteRendererCData>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<StartDoAniEvent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<Unity.Entities.Disabled>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<Unity.Entities.LinkedEntityGroup>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<Unity.Transforms.LocalTransform>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<Unity.Transforms.Parent>()
		// Unity.Entities.ComponentType Unity.Entities.ComponentType.ReadWrite<object>()
		// System.Void Unity.Entities.EntityCommandBuffer.AddComponent<AudioSourceData>(Unity.Entities.Entity,AudioSourceData)
		// System.Void Unity.Entities.EntityCommandBuffer.AddComponent<GameObjectCData>(Unity.Entities.Entity,GameObjectCData)
		// System.Void Unity.Entities.EntityCommandBuffer.AddComponent<LinkedEntityComponent>(Unity.Entities.Entity,LinkedEntityComponent)
		// System.Void Unity.Entities.EntityCommandBuffer.AddComponent<PokerPoolCData>(Unity.Entities.Entity,PokerPoolCData)
		// System.Void Unity.Entities.EntityCommandBuffer.AddComponent<SpriteRendererCData>(Unity.Entities.Entity,SpriteRendererCData)
		// System.Void Unity.Entities.EntityCommandBuffer.ParallelWriter.AddComponent<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(int,Unity.Entities.Entity,PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent)
		// System.Void Unity.Entities.EntityCommandBuffer.ParallelWriter.AddComponent<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(int,Unity.Entities.Entity,PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent)
		// System.Void Unity.Entities.EntityCommandBuffer.ParallelWriter.AddComponent<PokerItemCData>(int,Unity.Entities.Entity,PokerItemCData)
		// System.Void Unity.Entities.EntityCommandBuffer.ParallelWriter.AddComponent<PokerTimerRemoveCData>(int,Unity.Entities.Entity,PokerTimerRemoveCData)
		// System.Void Unity.Entities.EntityCommandBuffer.ParallelWriter.AddComponent<Unity.Transforms.LocalTransform>(int,Unity.Entities.Entity,Unity.Transforms.LocalTransform)
		// System.Void Unity.Entities.EntityCommandBuffer.ParallelWriter.AddComponent<Unity.Transforms.Parent>(int,Unity.Entities.Entity,Unity.Transforms.Parent)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<AudioSourceData>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,AudioSourceData)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<GameObjectCData>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,GameObjectCData)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<LinkedEntityComponent>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,LinkedEntityComponent)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<PokerItemCData>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,PokerItemCData)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<PokerPoolCData>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,PokerPoolCData)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<PokerTimerRemoveCData>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,PokerTimerRemoveCData)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<SpriteRendererCData>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,SpriteRendererCData)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<Unity.Transforms.LocalTransform>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,Unity.Transforms.LocalTransform)
		// System.Void Unity.Entities.EntityCommandBufferData.AddEntityComponentTypeWithValueCommand<Unity.Transforms.Parent>(Unity.Entities.EntityCommandBufferChain*,int,Unity.Entities.ECBCommand,Unity.Entities.Entity,Unity.Transforms.Parent)
		// Unity.Entities.DynamicBuffer<Unity.Entities.LinkedEntityGroup> Unity.Entities.EntityDataAccess.GetBuffer<Unity.Entities.LinkedEntityGroup>(Unity.Entities.Entity,bool)
		// GameObjectCData Unity.Entities.EntityDataAccess.GetComponentData<GameObjectCData>(Unity.Entities.Entity)
		// PokerAnimationCData Unity.Entities.EntityDataAccess.GetComponentData<PokerAnimationCData>(Unity.Entities.Entity)
		// PokerAnimationCData2 Unity.Entities.EntityDataAccess.GetComponentData<PokerAnimationCData2>(Unity.Entities.Entity)
		// PoolTag Unity.Entities.EntityDataAccess.GetComponentData<PoolTag>(Unity.Entities.Entity)
		// System.Void Unity.Entities.EntityDataAccess.SetComponentData<PokerAnimationCData>(Unity.Entities.Entity,PokerAnimationCData,Unity.Entities.SystemHandle&)
		// System.Void Unity.Entities.EntityDataAccess.SetComponentData<PokerItemCData>(Unity.Entities.Entity,PokerItemCData,Unity.Entities.SystemHandle&)
		// System.Void Unity.Entities.EntityDataAccess.SetComponentData<PokerTimerRemoveCData>(Unity.Entities.Entity,PokerTimerRemoveCData,Unity.Entities.SystemHandle&)
		// System.Void Unity.Entities.EntityDataAccess.SetComponentData<PoolTag>(Unity.Entities.Entity,PoolTag,Unity.Entities.SystemHandle&)
		// System.Void Unity.Entities.EntityDataAccess.SetComponentData<Unity.Transforms.Parent>(Unity.Entities.Entity,Unity.Transforms.Parent,Unity.Entities.SystemHandle&)
		// object Unity.Entities.EntityDataAccessManagedComponentExtensions.GetComponentObject<object>(Unity.Entities.EntityDataAccess&,Unity.Entities.Entity,Unity.Entities.ComponentType)
		// bool Unity.Entities.EntityManager.AddComponent<PlayAudioRequest>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.AddComponent<PokerAnimationCData2>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.AddComponent<PokerItemCData>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.AddComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.AddComponent<Unity.Transforms.Parent>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.AddComponent<object>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.AddComponentData<PokerAnimationCData>(Unity.Entities.Entity,PokerAnimationCData)
		// bool Unity.Entities.EntityManager.AddComponentData<PokerItemCData>(Unity.Entities.Entity,PokerItemCData)
		// bool Unity.Entities.EntityManager.AddComponentData<PokerTimerRemoveCData>(Unity.Entities.Entity,PokerTimerRemoveCData)
		// bool Unity.Entities.EntityManager.AddComponentData<PoolTag>(Unity.Entities.Entity,PoolTag)
		// bool Unity.Entities.EntityManager.AddComponentData<Unity.Transforms.Parent>(Unity.Entities.Entity,Unity.Transforms.Parent)
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<AttackComponent>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<AudioReference>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<GameObjectCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<LinkedEntityComponent>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<PlayAudioRequest>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<PokerAnimationCData2>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<PokerItemCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<PokerPoolCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<SpriteRendererCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<StartDoAniEvent>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRO<Unity.Transforms.LocalTransform>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<AudioSourceData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<PokerAnimationCData2>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<PokerAnimationCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<PokerItemCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<PokerTimerRemoveCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<SpriteRendererCData>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<Unity.Transforms.LocalTransform>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<Unity.Transforms.Parent>()
		// System.Void Unity.Entities.EntityManager.CompleteDependencyBeforeRW<object>()
		// Unity.Entities.DynamicBuffer<Unity.Entities.LinkedEntityGroup> Unity.Entities.EntityManager.GetBuffer<Unity.Entities.LinkedEntityGroup>(Unity.Entities.Entity,bool)
		// Unity.Entities.DynamicBuffer<Unity.Entities.LinkedEntityGroup> Unity.Entities.EntityManager.GetBufferInternal<Unity.Entities.LinkedEntityGroup>(Unity.Entities.EntityDataAccess*,Unity.Entities.Entity,bool)
		// GameObjectCData Unity.Entities.EntityManager.GetComponentData<GameObjectCData>(Unity.Entities.Entity)
		// PokerAnimationCData Unity.Entities.EntityManager.GetComponentData<PokerAnimationCData>(Unity.Entities.Entity)
		// PokerAnimationCData2 Unity.Entities.EntityManager.GetComponentData<PokerAnimationCData2>(Unity.Entities.Entity)
		// PoolTag Unity.Entities.EntityManager.GetComponentData<PoolTag>(Unity.Entities.Entity)
		// Unity.Entities.ComponentLookup<PokerAnimationCData2> Unity.Entities.EntityManager.GetComponentLookup<PokerAnimationCData2>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<PokerAnimationCData2> Unity.Entities.EntityManager.GetComponentLookup<PokerAnimationCData2>(bool)
		// Unity.Entities.ComponentLookup<PokerAnimationCData> Unity.Entities.EntityManager.GetComponentLookup<PokerAnimationCData>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<PokerAnimationCData> Unity.Entities.EntityManager.GetComponentLookup<PokerAnimationCData>(bool)
		// Unity.Entities.ComponentLookup<PokerItemCData> Unity.Entities.EntityManager.GetComponentLookup<PokerItemCData>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<PokerItemCData> Unity.Entities.EntityManager.GetComponentLookup<PokerItemCData>(bool)
		// Unity.Entities.ComponentLookup<PokerTimerRemoveCData> Unity.Entities.EntityManager.GetComponentLookup<PokerTimerRemoveCData>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<PokerTimerRemoveCData> Unity.Entities.EntityManager.GetComponentLookup<PokerTimerRemoveCData>(bool)
		// Unity.Entities.ComponentLookup<SpriteRendererCData> Unity.Entities.EntityManager.GetComponentLookup<SpriteRendererCData>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<SpriteRendererCData> Unity.Entities.EntityManager.GetComponentLookup<SpriteRendererCData>(bool)
		// Unity.Entities.ComponentLookup<Unity.Transforms.LocalTransform> Unity.Entities.EntityManager.GetComponentLookup<Unity.Transforms.LocalTransform>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<Unity.Transforms.LocalTransform> Unity.Entities.EntityManager.GetComponentLookup<Unity.Transforms.LocalTransform>(bool)
		// Unity.Entities.ComponentLookup<Unity.Transforms.Parent> Unity.Entities.EntityManager.GetComponentLookup<Unity.Transforms.Parent>(Unity.Entities.TypeIndex,bool)
		// Unity.Entities.ComponentLookup<Unity.Transforms.Parent> Unity.Entities.EntityManager.GetComponentLookup<Unity.Transforms.Parent>(bool)
		// object Unity.Entities.EntityManager.GetComponentObject<object>(Unity.Entities.Entity)
		// Unity.Entities.ComponentTypeHandle<AttackComponent> Unity.Entities.EntityManager.GetComponentTypeHandle<AttackComponent>(bool)
		// Unity.Entities.ComponentTypeHandle<AudioReference> Unity.Entities.EntityManager.GetComponentTypeHandle<AudioReference>(bool)
		// Unity.Entities.ComponentTypeHandle<AudioSourceData> Unity.Entities.EntityManager.GetComponentTypeHandle<AudioSourceData>(bool)
		// Unity.Entities.ComponentTypeHandle<GameObjectCData> Unity.Entities.EntityManager.GetComponentTypeHandle<GameObjectCData>(bool)
		// Unity.Entities.ComponentTypeHandle<LinkedEntityComponent> Unity.Entities.EntityManager.GetComponentTypeHandle<LinkedEntityComponent>(bool)
		// Unity.Entities.ComponentTypeHandle<PlayAudioRequest> Unity.Entities.EntityManager.GetComponentTypeHandle<PlayAudioRequest>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent> Unity.Entities.EntityManager.GetComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent> Unity.Entities.EntityManager.GetComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerAnimationCData2> Unity.Entities.EntityManager.GetComponentTypeHandle<PokerAnimationCData2>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerItemCData> Unity.Entities.EntityManager.GetComponentTypeHandle<PokerItemCData>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerPoolCData> Unity.Entities.EntityManager.GetComponentTypeHandle<PokerPoolCData>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerTimerRemoveCData> Unity.Entities.EntityManager.GetComponentTypeHandle<PokerTimerRemoveCData>(bool)
		// Unity.Entities.ComponentTypeHandle<SpriteRendererCData> Unity.Entities.EntityManager.GetComponentTypeHandle<SpriteRendererCData>(bool)
		// Unity.Entities.ComponentTypeHandle<StartDoAniEvent> Unity.Entities.EntityManager.GetComponentTypeHandle<StartDoAniEvent>(bool)
		// Unity.Entities.ComponentTypeHandle<Unity.Transforms.LocalTransform> Unity.Entities.EntityManager.GetComponentTypeHandle<Unity.Transforms.LocalTransform>(bool)
		// Unity.Entities.ComponentTypeHandle<object> Unity.Entities.EntityManager.GetComponentTypeHandle<object>(bool)
		// bool Unity.Entities.EntityManager.HasBuffer<Unity.Entities.LinkedEntityGroup>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<AudioSourceData>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<GameObjectCData>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<PokerAnimationCData2>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<PokerItemCData>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<PoolTag>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<Unity.Transforms.LocalTransform>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<Unity.Transforms.Parent>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.HasComponent<object>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.RemoveComponent<PlayAudioRequest>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.RemoveComponent<PokerTimerRemoveCData>(Unity.Entities.Entity)
		// bool Unity.Entities.EntityManager.RemoveComponent<Unity.Entities.Disabled>(Unity.Entities.Entity)
		// System.Void Unity.Entities.EntityManager.SetComponentData<PokerAnimationCData>(Unity.Entities.Entity,PokerAnimationCData)
		// System.Void Unity.Entities.EntityManager.SetComponentData<PokerItemCData>(Unity.Entities.Entity,PokerItemCData)
		// System.Void Unity.Entities.EntityManager.SetComponentData<PokerTimerRemoveCData>(Unity.Entities.Entity,PokerTimerRemoveCData)
		// System.Void Unity.Entities.EntityManager.SetComponentData<PoolTag>(Unity.Entities.Entity,PoolTag)
		// System.Void Unity.Entities.EntityManager.SetComponentData<Unity.Transforms.Parent>(Unity.Entities.Entity,Unity.Transforms.Parent)
		// PokerSystemSingleton Unity.Entities.EntityQuery.GetSingleton<PokerSystemSingleton>()
		// Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton Unity.Entities.EntityQuery.GetSingleton<Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton>()
		// Unity.Entities.RefRW<PokerSystemSingleton> Unity.Entities.EntityQuery.GetSingletonRW<PokerSystemSingleton>()
		// bool Unity.Entities.EntityQuery.HasSingleton<PokerSystemSingleton>()
		// bool Unity.Entities.EntityQuery.TryGetSingletonEntity<PokerGoMgrInitFinishEvent>(Unity.Entities.Entity&)
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<AttackComponent>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<AudioReference>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<GameObjectCData>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<LinkedEntityComponent>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PlayAudioRequest>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerAnimationCData2>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerGoMgrInitFinishEvent>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerItemCData>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerPoolCData>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<PokerSystemSingleton>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<SpriteRendererCData>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<StartDoAniEvent>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAll<Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAllRW<AudioSourceData>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAllRW<PokerAnimationCData2>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAllRW<PokerSystemSingleton>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAllRW<PokerTimerRemoveCData>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAllRW<Unity.Transforms.LocalTransform>()
		// Unity.Entities.EntityQueryBuilder Unity.Entities.EntityQueryBuilder.WithAllRW<object>()
		// PokerSystemSingleton Unity.Entities.EntityQueryImpl.GetSingleton<PokerSystemSingleton>()
		// Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton Unity.Entities.EntityQueryImpl.GetSingleton<Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton>()
		// Unity.Entities.RefRW<PokerSystemSingleton> Unity.Entities.EntityQueryImpl.GetSingletonRW<PokerSystemSingleton>()
		// bool Unity.Entities.EntityQueryImpl.HasSingleton<PokerGoMgrInitFinishEvent>()
		// bool Unity.Entities.EntityQueryImpl.HasSingleton<PokerSystemSingleton>()
		// bool Unity.Entities.EntityQueryImpl.TryGetSingletonEntity<PokerGoMgrInitFinishEvent>(Unity.Entities.Entity&)
		// System.Void Unity.Entities.IBaker.AddComponent<AudioSourceData>(Unity.Entities.Entity,AudioSourceData&)
		// System.Void Unity.Entities.IBaker.AddComponent<GameObjectCData>(Unity.Entities.Entity,GameObjectCData&)
		// System.Void Unity.Entities.IBaker.AddComponent<LinkedEntityComponent>(Unity.Entities.Entity,LinkedEntityComponent&)
		// System.Void Unity.Entities.IBaker.AddComponent<PokerPoolCData>(Unity.Entities.Entity,PokerPoolCData&)
		// System.Void Unity.Entities.IBaker.AddComponent<SpriteRendererCData>(Unity.Entities.Entity,SpriteRendererCData&)
		// System.Void Unity.Entities.IBaker.AddDebugTrackingForComponent<AudioSourceData>(Unity.Entities.Entity)
		// System.Void Unity.Entities.IBaker.AddDebugTrackingForComponent<GameObjectCData>(Unity.Entities.Entity)
		// System.Void Unity.Entities.IBaker.AddDebugTrackingForComponent<LinkedEntityComponent>(Unity.Entities.Entity)
		// System.Void Unity.Entities.IBaker.AddDebugTrackingForComponent<PokerPoolCData>(Unity.Entities.Entity)
		// System.Void Unity.Entities.IBaker.AddDebugTrackingForComponent<SpriteRendererCData>(Unity.Entities.Entity)
		// System.Void Unity.Entities.IBaker.AddTrackingForComponent<AudioSourceData>()
		// System.Void Unity.Entities.IBaker.AddTrackingForComponent<GameObjectCData>()
		// System.Void Unity.Entities.IBaker.AddTrackingForComponent<LinkedEntityComponent>()
		// System.Void Unity.Entities.IBaker.AddTrackingForComponent<PokerPoolCData>()
		// System.Void Unity.Entities.IBaker.AddTrackingForComponent<SpriteRendererCData>()
		// Unity.Entities.RefRO<PokerAnimationCData2> Unity.Entities.Internal.InternalCompilerInterface.GetComponentROAfterCompletingDependency<PokerAnimationCData2>(Unity.Entities.ComponentLookup<PokerAnimationCData2>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRO<Unity.Transforms.LocalTransform> Unity.Entities.Internal.InternalCompilerInterface.GetComponentROAfterCompletingDependency<Unity.Transforms.LocalTransform>(Unity.Entities.ComponentLookup<Unity.Transforms.LocalTransform>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<PokerAnimationCData2> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<PokerAnimationCData2>(Unity.Entities.ComponentLookup<PokerAnimationCData2>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<PokerAnimationCData> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<PokerAnimationCData>(Unity.Entities.ComponentLookup<PokerAnimationCData>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<PokerItemCData> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<PokerItemCData>(Unity.Entities.ComponentLookup<PokerItemCData>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<PokerTimerRemoveCData> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<PokerTimerRemoveCData>(Unity.Entities.ComponentLookup<PokerTimerRemoveCData>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<SpriteRendererCData> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<SpriteRendererCData>(Unity.Entities.ComponentLookup<SpriteRendererCData>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<Unity.Transforms.LocalTransform> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<Unity.Transforms.LocalTransform>(Unity.Entities.ComponentLookup<Unity.Transforms.LocalTransform>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// Unity.Entities.RefRW<Unity.Transforms.Parent> Unity.Entities.Internal.InternalCompilerInterface.GetComponentRWAfterCompletingDependency<Unity.Transforms.Parent>(Unity.Entities.ComponentLookup<Unity.Transforms.Parent>&,Unity.Entities.SystemState&,Unity.Entities.Entity)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<PokerAnimationCData2>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle<PokerAnimationCData2>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<PokerTimerRemoveCData>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle<PokerTimerRemoveCData>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<Unity.Transforms.LocalTransform>(Unity.Entities.ArchetypeChunk,Unity.Entities.ComponentTypeHandle<Unity.Transforms.LocalTransform>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtrWithoutChecks<AudioSourceData>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<AudioSourceData>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<AttackComponent>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<AttackComponent>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<AudioReference>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<AudioReference>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<GameObjectCData>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<GameObjectCData>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<LinkedEntityComponent>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<LinkedEntityComponent>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<PlayAudioRequest>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<PlayAudioRequest>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<PokerItemCData>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<PokerItemCData>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<PokerPoolCData>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<PokerPoolCData>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<SpriteRendererCData>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<SpriteRendererCData>&)
		// System.IntPtr Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayReadOnlyIntPtrWithoutChecks<StartDoAniEvent>(Unity.Entities.ArchetypeChunk&,Unity.Entities.ComponentTypeHandle<StartDoAniEvent>&)
		// Unity.Entities.Entity Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Unity.Entities.Entity>(System.IntPtr,int)
		// PokerAnimationCData2& Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<PokerAnimationCData2>(System.IntPtr,int)
		// PokerTimerRemoveCData& Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<PokerTimerRemoveCData>(System.IntPtr,int)
		// Unity.Transforms.LocalTransform& Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<Unity.Transforms.LocalTransform>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AttackComponent> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<AttackComponent>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<AudioReference> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<AudioReference>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<GameObjectCData> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<GameObjectCData>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<LinkedEntityComponent> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<LinkedEntityComponent>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PlayAudioRequest> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<PlayAudioRequest>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerItemCData> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<PokerItemCData>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<PokerPoolCData> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<PokerPoolCData>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<SpriteRendererCData> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<SpriteRendererCData>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRO<StartDoAniEvent> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRO<StartDoAniEvent>(System.IntPtr,int)
		// Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<AudioSourceData> Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRW<AudioSourceData>(System.IntPtr,int)
		// Unity.Jobs.JobHandle Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.ScheduleParallelByRef<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>(PokerAniSystem_FlyFullScreen3.TimerRemoveJob&,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle,Unity.Collections.NativeArray<int>)
		// Unity.Jobs.JobHandle Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.ScheduleParallelByRef<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>(PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob&,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle,Unity.Collections.NativeArray<int>)
		// System.Void Unity.Entities.JobChunkExtensions.EarlyJobInit<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>()
		// System.Void Unity.Entities.JobChunkExtensions.EarlyJobInit<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>()
		// System.Void Unity.Entities.JobChunkExtensions.RunByRef<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>(PokerAniSystem_FlyFullScreen3.TimerRemoveJob&,Unity.Entities.EntityQuery)
		// System.Void Unity.Entities.JobChunkExtensions.RunByRef<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>(PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob&,Unity.Entities.EntityQuery)
		// Unity.Jobs.JobHandle Unity.Entities.JobChunkExtensions.ScheduleByRef<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>(PokerAniSystem_FlyFullScreen3.TimerRemoveJob&,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle)
		// Unity.Jobs.JobHandle Unity.Entities.JobChunkExtensions.ScheduleByRef<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>(PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob&,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle)
		// Unity.Jobs.JobHandle Unity.Entities.JobChunkExtensions.ScheduleInternal<PokerAniSystem_FlyFullScreen3.TimerRemoveJob>(PokerAniSystem_FlyFullScreen3.TimerRemoveJob&,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle,Unity.Jobs.LowLevel.Unsafe.ScheduleMode,Unity.Collections.NativeArray<int>)
		// Unity.Jobs.JobHandle Unity.Entities.JobChunkExtensions.ScheduleInternal<PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob>(PokerAniSystem_FlyFullScreen3.UpdateCardAnimationJob&,Unity.Entities.EntityQuery,Unity.Jobs.JobHandle,Unity.Jobs.LowLevel.Unsafe.ScheduleMode,Unity.Collections.NativeArray<int>)
		// Unity.Entities.ComponentLookup<PokerAnimationCData2> Unity.Entities.SystemState.GetComponentLookup<PokerAnimationCData2>(bool)
		// Unity.Entities.ComponentLookup<PokerAnimationCData> Unity.Entities.SystemState.GetComponentLookup<PokerAnimationCData>(bool)
		// Unity.Entities.ComponentLookup<PokerItemCData> Unity.Entities.SystemState.GetComponentLookup<PokerItemCData>(bool)
		// Unity.Entities.ComponentLookup<PokerTimerRemoveCData> Unity.Entities.SystemState.GetComponentLookup<PokerTimerRemoveCData>(bool)
		// Unity.Entities.ComponentLookup<SpriteRendererCData> Unity.Entities.SystemState.GetComponentLookup<SpriteRendererCData>(bool)
		// Unity.Entities.ComponentLookup<Unity.Transforms.LocalTransform> Unity.Entities.SystemState.GetComponentLookup<Unity.Transforms.LocalTransform>(bool)
		// Unity.Entities.ComponentLookup<Unity.Transforms.Parent> Unity.Entities.SystemState.GetComponentLookup<Unity.Transforms.Parent>(bool)
		// Unity.Entities.ComponentTypeHandle<AttackComponent> Unity.Entities.SystemState.GetComponentTypeHandle<AttackComponent>(bool)
		// Unity.Entities.ComponentTypeHandle<AudioReference> Unity.Entities.SystemState.GetComponentTypeHandle<AudioReference>(bool)
		// Unity.Entities.ComponentTypeHandle<AudioSourceData> Unity.Entities.SystemState.GetComponentTypeHandle<AudioSourceData>(bool)
		// Unity.Entities.ComponentTypeHandle<GameObjectCData> Unity.Entities.SystemState.GetComponentTypeHandle<GameObjectCData>(bool)
		// Unity.Entities.ComponentTypeHandle<LinkedEntityComponent> Unity.Entities.SystemState.GetComponentTypeHandle<LinkedEntityComponent>(bool)
		// Unity.Entities.ComponentTypeHandle<PlayAudioRequest> Unity.Entities.SystemState.GetComponentTypeHandle<PlayAudioRequest>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent> Unity.Entities.SystemState.GetComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent> Unity.Entities.SystemState.GetComponentTypeHandle<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerAnimationCData2> Unity.Entities.SystemState.GetComponentTypeHandle<PokerAnimationCData2>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerItemCData> Unity.Entities.SystemState.GetComponentTypeHandle<PokerItemCData>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerPoolCData> Unity.Entities.SystemState.GetComponentTypeHandle<PokerPoolCData>(bool)
		// Unity.Entities.ComponentTypeHandle<PokerTimerRemoveCData> Unity.Entities.SystemState.GetComponentTypeHandle<PokerTimerRemoveCData>(bool)
		// Unity.Entities.ComponentTypeHandle<SpriteRendererCData> Unity.Entities.SystemState.GetComponentTypeHandle<SpriteRendererCData>(bool)
		// Unity.Entities.ComponentTypeHandle<StartDoAniEvent> Unity.Entities.SystemState.GetComponentTypeHandle<StartDoAniEvent>(bool)
		// Unity.Entities.ComponentTypeHandle<Unity.Transforms.LocalTransform> Unity.Entities.SystemState.GetComponentTypeHandle<Unity.Transforms.LocalTransform>(bool)
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<AttackComponent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<AudioReference>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<AudioSourceData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<GameObjectCData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<LinkedEntityComponent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PlayAudioRequest>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerAnimationCData2>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerAnimationCData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerGoMgrInitFinishEvent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerItemCData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerPoolCData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerSystemSingleton>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PokerTimerRemoveCData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<PoolTag>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<SpriteRendererCData>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<StartDoAniEvent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<Unity.Entities.Disabled>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<Unity.Entities.LinkedEntityGroup>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<Unity.Transforms.LocalTransform>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<Unity.Transforms.Parent>()
		// Unity.Entities.TypeIndex Unity.Entities.TypeManager.GetTypeIndex<object>()
		// System.Void Unity.Entities.TypeManager.ManagedException<AttackComponent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<AudioReference>()
		// System.Void Unity.Entities.TypeManager.ManagedException<AudioSourceData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<GameObjectCData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<LinkedEntityComponent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PlayAudioRequest>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerAniSystem_FlyFullScreen3.SetPokerItemDataEvent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerAniSystem_FlyFullScreen3.SetPokerItemSortingOrderEvent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerAnimationCData2>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerAnimationCData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerGoMgrInitFinishEvent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerItemCData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerPoolCData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerSystemSingleton>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PokerTimerRemoveCData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<PoolTag>()
		// System.Void Unity.Entities.TypeManager.ManagedException<SpriteRendererCData>()
		// System.Void Unity.Entities.TypeManager.ManagedException<StartDoAniEvent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<Unity.Entities.Disabled>()
		// System.Void Unity.Entities.TypeManager.ManagedException<Unity.Entities.EndSimulationEntityCommandBufferSystem.Singleton>()
		// System.Void Unity.Entities.TypeManager.ManagedException<Unity.Entities.LinkedEntityGroup>()
		// System.Void Unity.Entities.TypeManager.ManagedException<Unity.Transforms.LocalTransform>()
		// System.Void Unity.Entities.TypeManager.ManagedException<Unity.Transforms.Parent>()
		// System.Void Unity.Entities.TypeManager.ManagedException<object>()
		// object UnityEngine.Component.GetComponent<object>()
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.GameObject.GetComponent<object>()
	}
}