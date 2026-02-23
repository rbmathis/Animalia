namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Campephilus;

/// <summary>
/// Interface defining characteristics of Campephilus (genus).
/// </summary>
public interface ICampephilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
