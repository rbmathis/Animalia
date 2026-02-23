namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Hartertula;

/// <summary>
/// Interface defining characteristics of Hartertula (genus).
/// </summary>
public interface IHartertula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
