namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudapocryptes;

/// <summary>
/// Interface defining characteristics of Pseudapocryptes (genus).
/// </summary>
public interface IPseudapocryptes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
