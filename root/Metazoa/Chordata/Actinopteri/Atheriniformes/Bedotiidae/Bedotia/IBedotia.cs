namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae.Bedotia;

/// <summary>
/// Interface defining characteristics of Bedotia (genus).
/// </summary>
public interface IBedotia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
