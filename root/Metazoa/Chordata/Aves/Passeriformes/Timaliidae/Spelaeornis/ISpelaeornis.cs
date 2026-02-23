namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Spelaeornis;

/// <summary>
/// Interface defining characteristics of Spelaeornis (genus).
/// </summary>
public interface ISpelaeornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
