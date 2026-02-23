namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Neoodax;

/// <summary>
/// Interface defining characteristics of Neoodax (genus).
/// </summary>
public interface INeoodax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
