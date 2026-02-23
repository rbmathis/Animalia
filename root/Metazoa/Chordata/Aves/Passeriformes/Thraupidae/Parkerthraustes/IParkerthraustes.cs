namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Parkerthraustes;

/// <summary>
/// Interface defining characteristics of Parkerthraustes (genus).
/// </summary>
public interface IParkerthraustes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
