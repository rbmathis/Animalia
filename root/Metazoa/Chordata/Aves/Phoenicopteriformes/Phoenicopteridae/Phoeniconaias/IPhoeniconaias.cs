namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Phoenicopteriformes.Phoenicopteridae.Phoeniconaias;

/// <summary>
/// Interface defining characteristics of Phoeniconaias (genus).
/// </summary>
public interface IPhoeniconaias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
