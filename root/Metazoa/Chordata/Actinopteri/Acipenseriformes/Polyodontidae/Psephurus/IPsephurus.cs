namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae.Psephurus;

/// <summary>
/// Interface defining characteristics of Psephurus (genus).
/// </summary>
public interface IPsephurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
