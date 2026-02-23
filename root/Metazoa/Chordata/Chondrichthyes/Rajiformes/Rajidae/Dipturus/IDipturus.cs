namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Dipturus;

/// <summary>
/// Interface defining characteristics of Dipturus (genus).
/// </summary>
public interface IDipturus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
