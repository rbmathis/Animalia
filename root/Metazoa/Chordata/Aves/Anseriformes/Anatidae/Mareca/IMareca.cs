namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Mareca;

/// <summary>
/// Interface defining characteristics of Mareca (genus).
/// </summary>
public interface IMareca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
