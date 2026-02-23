namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Myliobatiformes.Gymnuridae.Gymnura;

/// <summary>
/// Interface defining characteristics of Gymnura (genus).
/// </summary>
public interface IGymnura
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
