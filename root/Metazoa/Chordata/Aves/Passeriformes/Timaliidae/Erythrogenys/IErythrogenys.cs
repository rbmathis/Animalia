namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Erythrogenys;

/// <summary>
/// Interface defining characteristics of Erythrogenys (genus).
/// </summary>
public interface IErythrogenys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
