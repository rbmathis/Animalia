namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bombinatoridae.Barbourula;

/// <summary>
/// Interface defining characteristics of Barbourula (genus).
/// </summary>
public interface IBarbourula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
