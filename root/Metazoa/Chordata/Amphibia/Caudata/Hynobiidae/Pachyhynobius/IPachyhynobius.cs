namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Pachyhynobius;

/// <summary>
/// Interface defining characteristics of Pachyhynobius (genus).
/// </summary>
public interface IPachyhynobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
