namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Frostius;

/// <summary>
/// Interface defining characteristics of Frostius (genus).
/// </summary>
public interface IFrostius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
