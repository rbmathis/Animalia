namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Pristolepididae.Pristolepis;

/// <summary>
/// Interface defining characteristics of Pristolepis (genus).
/// </summary>
public interface IPristolepis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
