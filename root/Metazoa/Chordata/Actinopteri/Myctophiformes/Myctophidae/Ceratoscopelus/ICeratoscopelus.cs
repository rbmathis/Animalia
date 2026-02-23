namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Ceratoscopelus;

/// <summary>
/// Interface defining characteristics of Ceratoscopelus (genus).
/// </summary>
public interface ICeratoscopelus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
