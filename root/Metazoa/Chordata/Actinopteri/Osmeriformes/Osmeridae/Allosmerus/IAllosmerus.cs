namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Osmeridae.Allosmerus;

/// <summary>
/// Interface defining characteristics of Allosmerus (genus).
/// </summary>
public interface IAllosmerus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
