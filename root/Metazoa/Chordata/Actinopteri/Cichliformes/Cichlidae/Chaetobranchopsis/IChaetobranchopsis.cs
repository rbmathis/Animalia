namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchopsis;

/// <summary>
/// Interface defining characteristics of Chaetobranchopsis (genus).
/// </summary>
public interface IChaetobranchopsis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
