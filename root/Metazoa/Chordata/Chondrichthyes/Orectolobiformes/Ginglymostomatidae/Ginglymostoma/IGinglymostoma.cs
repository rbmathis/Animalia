namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Ginglymostomatidae.Ginglymostoma;

/// <summary>
/// Interface defining characteristics of Ginglymostoma (genus).
/// </summary>
public interface IGinglymostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
