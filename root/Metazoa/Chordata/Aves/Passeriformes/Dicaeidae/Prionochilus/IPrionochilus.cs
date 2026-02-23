namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae.Prionochilus;

/// <summary>
/// Interface defining characteristics of Prionochilus (genus).
/// </summary>
public interface IPrionochilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
