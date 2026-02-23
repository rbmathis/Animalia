namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Xenodermus;

/// <summary>
/// Interface defining characteristics of Xenodermus (genus).
/// </summary>
public interface IXenodermus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
