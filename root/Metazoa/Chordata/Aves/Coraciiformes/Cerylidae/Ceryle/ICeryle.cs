namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae.Ceryle;

/// <summary>
/// Interface defining characteristics of Ceryle (genus).
/// </summary>
public interface ICeryle
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
