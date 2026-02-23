namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Ctenolabrus;

/// <summary>
/// Interface defining characteristics of Ctenolabrus (genus).
/// </summary>
public interface ICtenolabrus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
