namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Monasa;

/// <summary>
/// Interface defining characteristics of Monasa (genus).
/// </summary>
public interface IMonasa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
