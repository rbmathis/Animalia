namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Aegithalidae.Psaltria;

/// <summary>
/// Interface defining characteristics of Psaltria (genus).
/// </summary>
public interface IPsaltria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
