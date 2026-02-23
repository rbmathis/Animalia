namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hepsetidae.Hepsetus;

/// <summary>
/// Interface defining characteristics of Hepsetus (genus).
/// </summary>
public interface IHepsetus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
