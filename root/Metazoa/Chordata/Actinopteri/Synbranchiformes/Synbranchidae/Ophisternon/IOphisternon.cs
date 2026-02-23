namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Ophisternon;

/// <summary>
/// Interface defining characteristics of Ophisternon (genus).
/// </summary>
public interface IOphisternon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
