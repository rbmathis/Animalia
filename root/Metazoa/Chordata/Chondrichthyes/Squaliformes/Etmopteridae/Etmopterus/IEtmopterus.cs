namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Etmopterus;

/// <summary>
/// Interface defining characteristics of Etmopterus (genus).
/// </summary>
public interface IEtmopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
