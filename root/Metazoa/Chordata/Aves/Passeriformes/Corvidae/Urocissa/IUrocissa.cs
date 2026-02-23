namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Urocissa;

/// <summary>
/// Interface defining characteristics of Urocissa (genus).
/// </summary>
public interface IUrocissa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
