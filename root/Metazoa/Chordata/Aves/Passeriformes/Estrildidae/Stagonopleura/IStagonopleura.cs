namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Stagonopleura;

/// <summary>
/// Interface defining characteristics of Stagonopleura (genus).
/// </summary>
public interface IStagonopleura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
