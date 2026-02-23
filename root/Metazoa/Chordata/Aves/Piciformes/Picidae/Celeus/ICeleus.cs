namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Celeus;

/// <summary>
/// Interface defining characteristics of Celeus (genus).
/// </summary>
public interface ICeleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
