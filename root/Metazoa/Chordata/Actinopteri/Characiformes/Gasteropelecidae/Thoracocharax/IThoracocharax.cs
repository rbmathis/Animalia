namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Thoracocharax;

/// <summary>
/// Interface defining characteristics of Thoracocharax (genus).
/// </summary>
public interface IThoracocharax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
