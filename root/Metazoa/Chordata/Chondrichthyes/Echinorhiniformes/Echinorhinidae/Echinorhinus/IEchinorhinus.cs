namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae.Echinorhinus;

/// <summary>
/// Interface defining characteristics of Echinorhinus (genus).
/// </summary>
public interface IEchinorhinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
