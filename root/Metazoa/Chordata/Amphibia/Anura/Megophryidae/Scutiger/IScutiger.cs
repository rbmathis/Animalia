namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Scutiger;

/// <summary>
/// Interface defining characteristics of Scutiger (genus).
/// </summary>
public interface IScutiger
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
