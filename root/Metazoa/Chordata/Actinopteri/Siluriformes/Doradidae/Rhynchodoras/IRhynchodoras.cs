namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Rhynchodoras;

/// <summary>
/// Interface defining characteristics of Rhynchodoras (genus).
/// </summary>
public interface IRhynchodoras
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
