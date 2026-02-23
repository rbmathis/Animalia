namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Cyphomyrus;

/// <summary>
/// Interface defining characteristics of Cyphomyrus (genus).
/// </summary>
public interface ICyphomyrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
