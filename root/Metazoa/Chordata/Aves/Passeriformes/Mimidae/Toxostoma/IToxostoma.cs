namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Toxostoma;

/// <summary>
/// Interface defining characteristics of Toxostoma (genus).
/// </summary>
public interface IToxostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
