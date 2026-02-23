namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Mantella;

/// <summary>
/// Interface defining characteristics of Mantella (genus).
/// </summary>
public interface IMantella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
