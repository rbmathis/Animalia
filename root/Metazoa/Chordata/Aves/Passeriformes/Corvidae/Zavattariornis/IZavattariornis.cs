namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Zavattariornis;

/// <summary>
/// Interface defining characteristics of Zavattariornis (genus).
/// </summary>
public interface IZavattariornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
