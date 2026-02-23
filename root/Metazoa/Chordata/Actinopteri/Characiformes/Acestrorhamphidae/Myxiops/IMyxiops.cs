namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Myxiops;

/// <summary>
/// Interface defining characteristics of Myxiops (genus).
/// </summary>
public interface IMyxiops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
