namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Estrilda;

/// <summary>
/// Interface defining characteristics of Estrilda (genus).
/// </summary>
public interface IEstrilda
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
