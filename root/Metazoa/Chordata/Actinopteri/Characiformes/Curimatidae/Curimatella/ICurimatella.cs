namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Curimatella;

/// <summary>
/// Interface defining characteristics of Curimatella (genus).
/// </summary>
public interface ICurimatella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
