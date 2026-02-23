namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Crossoptilon;

/// <summary>
/// Interface defining characteristics of Crossoptilon (genus).
/// </summary>
public interface ICrossoptilon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
