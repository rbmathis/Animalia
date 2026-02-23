namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Erythropitta;

/// <summary>
/// Interface defining characteristics of Erythropitta (genus).
/// </summary>
public interface IErythropitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
