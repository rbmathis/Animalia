namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Veliferidae.Metavelifer;

/// <summary>
/// Interface defining characteristics of Metavelifer (genus).
/// </summary>
public interface IMetavelifer
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
