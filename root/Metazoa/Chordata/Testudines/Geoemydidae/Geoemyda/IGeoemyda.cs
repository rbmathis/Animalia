namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Geoemyda;

/// <summary>
/// Interface defining characteristics of Geoemyda (genus).
/// </summary>
public interface IGeoemyda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
