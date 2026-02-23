namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Campicoloides;

/// <summary>
/// Interface defining characteristics of Campicoloides (genus).
/// </summary>
public interface ICampicoloides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
