namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Kryptophanaron;

/// <summary>
/// Interface defining characteristics of Kryptophanaron (genus).
/// </summary>
public interface IKryptophanaron
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
