namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae.Coreoperca;

/// <summary>
/// Interface defining characteristics of Coreoperca (genus).
/// </summary>
public interface ICoreoperca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
