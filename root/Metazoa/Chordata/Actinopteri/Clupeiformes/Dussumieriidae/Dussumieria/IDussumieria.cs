namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Dussumieriidae.Dussumieria;

/// <summary>
/// Interface defining characteristics of Dussumieria (genus).
/// </summary>
public interface IDussumieria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
