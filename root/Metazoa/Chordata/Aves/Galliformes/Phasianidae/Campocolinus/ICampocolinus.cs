namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Campocolinus;

/// <summary>
/// Interface defining characteristics of Campocolinus (genus).
/// </summary>
public interface ICampocolinus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
