namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Dendroperdix;

/// <summary>
/// Interface defining characteristics of Dendroperdix (genus).
/// </summary>
public interface IDendroperdix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
