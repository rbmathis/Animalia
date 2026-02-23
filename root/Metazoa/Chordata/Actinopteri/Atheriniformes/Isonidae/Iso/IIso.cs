namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Isonidae.Iso;

/// <summary>
/// Interface defining characteristics of Iso (genus).
/// </summary>
public interface IIso
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
