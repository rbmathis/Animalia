namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Calyptocephalellidae.Telmatobufo;

/// <summary>
/// Interface defining characteristics of Telmatobufo (genus).
/// </summary>
public interface ITelmatobufo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
