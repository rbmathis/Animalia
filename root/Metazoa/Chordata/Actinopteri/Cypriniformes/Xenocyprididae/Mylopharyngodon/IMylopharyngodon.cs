namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Mylopharyngodon;

/// <summary>
/// Interface defining characteristics of Mylopharyngodon (genus).
/// </summary>
public interface IMylopharyngodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
