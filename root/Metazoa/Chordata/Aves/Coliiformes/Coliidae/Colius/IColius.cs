namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Colius;

/// <summary>
/// Interface defining characteristics of Colius (genus).
/// </summary>
public interface IColius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
