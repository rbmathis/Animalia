namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Dendragapus;

/// <summary>
/// Interface defining characteristics of Dendragapus (genus).
/// </summary>
public interface IDendragapus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
