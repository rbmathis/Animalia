namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pternistis;

/// <summary>
/// Interface defining characteristics of Pternistis (genus).
/// </summary>
public interface IPternistis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
