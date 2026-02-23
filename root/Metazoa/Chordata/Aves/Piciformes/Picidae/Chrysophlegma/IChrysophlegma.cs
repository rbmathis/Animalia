namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Chrysophlegma;

/// <summary>
/// Interface defining characteristics of Chrysophlegma (genus).
/// </summary>
public interface IChrysophlegma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
