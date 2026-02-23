namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Potoroidae.Bettongia;

/// <summary>
/// Interface defining characteristics of Bettongia (genus).
/// </summary>
public interface IBettongia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
