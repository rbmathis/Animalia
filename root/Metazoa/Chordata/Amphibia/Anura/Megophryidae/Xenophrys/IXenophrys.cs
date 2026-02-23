namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Xenophrys;

/// <summary>
/// Interface defining characteristics of Xenophrys (genus).
/// </summary>
public interface IXenophrys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
