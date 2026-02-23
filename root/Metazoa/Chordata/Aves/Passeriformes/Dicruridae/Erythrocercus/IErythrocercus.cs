namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae.Erythrocercus;

/// <summary>
/// Interface defining characteristics of Erythrocercus (genus).
/// </summary>
public interface IErythrocercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
