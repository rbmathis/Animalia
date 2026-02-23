namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Tincidae.Tinca;

/// <summary>
/// Interface defining characteristics of Tinca (genus).
/// </summary>
public interface ITinca
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
