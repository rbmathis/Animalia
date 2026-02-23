namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Eupleurogrammus;

/// <summary>
/// Interface defining characteristics of Eupleurogrammus (genus).
/// </summary>
public interface IEupleurogrammus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
