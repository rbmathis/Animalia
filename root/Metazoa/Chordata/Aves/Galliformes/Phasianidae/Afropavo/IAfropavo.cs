namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Afropavo;

/// <summary>
/// Interface defining characteristics of Afropavo (genus).
/// </summary>
public interface IAfropavo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
