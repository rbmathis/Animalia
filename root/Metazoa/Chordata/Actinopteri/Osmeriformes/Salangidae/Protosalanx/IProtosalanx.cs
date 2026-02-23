namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Protosalanx;

/// <summary>
/// Interface defining characteristics of Protosalanx (genus).
/// </summary>
public interface IProtosalanx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
