namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Haematortyx;

/// <summary>
/// Interface defining characteristics of Haematortyx (genus).
/// </summary>
public interface IHaematortyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
