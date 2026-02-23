namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Cyphocharax;

/// <summary>
/// Interface defining characteristics of Cyphocharax (genus).
/// </summary>
public interface ICyphocharax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
