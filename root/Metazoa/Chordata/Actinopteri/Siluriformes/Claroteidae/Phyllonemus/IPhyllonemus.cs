namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Phyllonemus;

/// <summary>
/// Interface defining characteristics of Phyllonemus (genus).
/// </summary>
public interface IPhyllonemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
