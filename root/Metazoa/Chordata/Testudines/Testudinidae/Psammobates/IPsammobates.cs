namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Psammobates;

/// <summary>
/// Interface defining characteristics of Psammobates (genus).
/// </summary>
public interface IPsammobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
