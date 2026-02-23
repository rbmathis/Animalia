namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae.Vombatus;

/// <summary>
/// Interface defining characteristics of Vombatus (genus).
/// </summary>
public interface IVombatus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
