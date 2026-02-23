namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Phthanophaneron;

/// <summary>
/// Interface defining characteristics of Phthanophaneron (genus).
/// </summary>
public interface IPhthanophaneron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
