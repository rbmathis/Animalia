namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Clupisoma;

/// <summary>
/// Interface defining characteristics of Clupisoma (genus).
/// </summary>
public interface IClupisoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
