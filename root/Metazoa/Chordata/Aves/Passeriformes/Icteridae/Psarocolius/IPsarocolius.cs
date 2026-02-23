namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Psarocolius;

/// <summary>
/// Interface defining characteristics of Psarocolius (genus).
/// </summary>
public interface IPsarocolius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
