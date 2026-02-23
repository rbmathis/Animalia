namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gaidropsaridae.Enchelyopus;

/// <summary>
/// Interface defining characteristics of Enchelyopus (genus).
/// </summary>
public interface IEnchelyopus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
