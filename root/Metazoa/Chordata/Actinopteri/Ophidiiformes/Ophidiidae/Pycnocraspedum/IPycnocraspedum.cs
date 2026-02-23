namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Pycnocraspedum;

/// <summary>
/// Interface defining characteristics of Pycnocraspedum (genus).
/// </summary>
public interface IPycnocraspedum
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
