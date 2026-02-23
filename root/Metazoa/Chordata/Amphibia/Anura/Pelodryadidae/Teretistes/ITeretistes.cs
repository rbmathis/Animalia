namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Teretistes;

/// <summary>
/// Interface defining characteristics of Teretistes (genus).
/// </summary>
public interface ITeretistes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
