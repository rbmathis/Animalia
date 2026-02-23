namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Mandingoa;

/// <summary>
/// Interface defining characteristics of Mandingoa (genus).
/// </summary>
public interface IMandingoa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
