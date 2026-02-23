namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Hardella;

/// <summary>
/// Interface defining characteristics of Hardella (genus).
/// </summary>
public interface IHardella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
