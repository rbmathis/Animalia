namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Rhynchocyclus;

/// <summary>
/// Interface defining characteristics of Rhynchocyclus (genus).
/// </summary>
public interface IRhynchocyclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
