namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tragopan;

/// <summary>
/// Interface defining characteristics of Tragopan (genus).
/// </summary>
public interface ITragopan
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
