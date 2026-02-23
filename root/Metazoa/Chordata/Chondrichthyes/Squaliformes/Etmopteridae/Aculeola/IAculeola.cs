namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Aculeola;

/// <summary>
/// Interface defining characteristics of Aculeola (genus).
/// </summary>
public interface IAculeola
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
