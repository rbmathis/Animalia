namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Schindleriidae.Schindleria;

/// <summary>
/// Interface defining characteristics of Schindleria (genus).
/// </summary>
public interface ISchindleria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
