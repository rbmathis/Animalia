namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anoplogasteridae.Anoplogaster;

/// <summary>
/// Interface defining characteristics of Anoplogaster (genus).
/// </summary>
public interface IAnoplogaster
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
