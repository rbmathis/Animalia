namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Spea;

/// <summary>
/// Interface defining characteristics of Spea (genus).
/// </summary>
public interface ISpea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
