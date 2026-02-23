namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Dibranchus;

/// <summary>
/// Interface defining characteristics of Dibranchus (genus).
/// </summary>
public interface IDibranchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
