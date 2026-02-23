namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Hippopotamyrus;

/// <summary>
/// Interface defining characteristics of Hippopotamyrus (genus).
/// </summary>
public interface IHippopotamyrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
