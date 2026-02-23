namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Plectropomus;

/// <summary>
/// Interface defining characteristics of Plectropomus (genus).
/// </summary>
public interface IPlectropomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
