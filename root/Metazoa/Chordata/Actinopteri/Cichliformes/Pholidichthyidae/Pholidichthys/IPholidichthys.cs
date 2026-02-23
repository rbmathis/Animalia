namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Pholidichthyidae.Pholidichthys;

/// <summary>
/// Interface defining characteristics of Pholidichthys (genus).
/// </summary>
public interface IPholidichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
