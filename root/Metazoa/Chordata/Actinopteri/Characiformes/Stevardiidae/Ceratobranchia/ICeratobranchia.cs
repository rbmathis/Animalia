namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Ceratobranchia;

/// <summary>
/// Interface defining characteristics of Ceratobranchia (genus).
/// </summary>
public interface ICeratobranchia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
