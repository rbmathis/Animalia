namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ctenopharyngodon;

/// <summary>
/// Interface defining characteristics of Ctenopharyngodon (genus).
/// </summary>
public interface ICtenopharyngodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
