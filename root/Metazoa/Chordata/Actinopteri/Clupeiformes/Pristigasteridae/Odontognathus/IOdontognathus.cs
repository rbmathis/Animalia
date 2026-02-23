namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Odontognathus;

/// <summary>
/// Interface defining characteristics of Odontognathus (genus).
/// </summary>
public interface IOdontognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
