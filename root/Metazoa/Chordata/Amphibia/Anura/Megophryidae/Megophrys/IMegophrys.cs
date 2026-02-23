namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys;

/// <summary>
/// Interface defining characteristics of Megophrys (genus).
/// </summary>
public interface IMegophrys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
