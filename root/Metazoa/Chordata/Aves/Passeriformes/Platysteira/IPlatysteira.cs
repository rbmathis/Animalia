namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Platysteira;

/// <summary>
/// Interface defining characteristics of Platysteira (genus).
/// </summary>
public interface IPlatysteira
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
