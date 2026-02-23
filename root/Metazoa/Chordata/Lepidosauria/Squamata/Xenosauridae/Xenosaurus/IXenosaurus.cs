namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenosauridae.Xenosaurus;

/// <summary>
/// Interface defining characteristics of Xenosaurus (genus).
/// </summary>
public interface IXenosaurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
