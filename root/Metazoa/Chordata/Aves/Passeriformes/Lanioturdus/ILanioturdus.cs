namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Lanioturdus;

/// <summary>
/// Interface defining characteristics of Lanioturdus (genus).
/// </summary>
public interface ILanioturdus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
