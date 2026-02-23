namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Rhinoclemmys;

/// <summary>
/// Interface defining characteristics of Rhinoclemmys (genus).
/// </summary>
public interface IRhinoclemmys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
