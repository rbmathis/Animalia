namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Benthodesmus;

/// <summary>
/// Interface defining characteristics of Benthodesmus (genus).
/// </summary>
public interface IBenthodesmus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
