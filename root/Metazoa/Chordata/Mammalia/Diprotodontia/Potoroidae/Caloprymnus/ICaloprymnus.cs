namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae.Caloprymnus;

/// <summary>
/// Interface defining characteristics of Caloprymnus (genus).
/// </summary>
public interface ICaloprymnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
