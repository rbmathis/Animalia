namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Staphida;

/// <summary>
/// Interface defining characteristics of Staphida (genus).
/// </summary>
public interface IStaphida
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
