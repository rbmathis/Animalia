namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Cerylidae.Chloroceryle;

/// <summary>
/// Interface defining characteristics of Chloroceryle (genus).
/// </summary>
public interface IChloroceryle
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
