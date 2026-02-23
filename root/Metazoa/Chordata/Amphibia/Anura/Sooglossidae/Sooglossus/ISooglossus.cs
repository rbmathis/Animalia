namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Sooglossidae.Sooglossus;

/// <summary>
/// Interface defining characteristics of Sooglossus (genus).
/// </summary>
public interface ISooglossus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
