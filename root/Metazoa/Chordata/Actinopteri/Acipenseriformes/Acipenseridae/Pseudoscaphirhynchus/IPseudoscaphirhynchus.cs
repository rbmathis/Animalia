namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Pseudoscaphirhynchus;

/// <summary>
/// Interface defining characteristics of Pseudoscaphirhynchus (genus).
/// </summary>
public interface IPseudoscaphirhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
