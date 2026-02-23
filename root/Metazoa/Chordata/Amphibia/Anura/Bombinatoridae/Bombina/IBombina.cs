namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Bombina;

/// <summary>
/// Interface defining characteristics of Bombina (genus).
/// </summary>
public interface IBombina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
