namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Myornis;

/// <summary>
/// Interface defining characteristics of Myornis (genus).
/// </summary>
public interface IMyornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
