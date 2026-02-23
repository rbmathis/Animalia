namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Pseudohynobius;

/// <summary>
/// Interface defining characteristics of Pseudohynobius (genus).
/// </summary>
public interface IPseudohynobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
