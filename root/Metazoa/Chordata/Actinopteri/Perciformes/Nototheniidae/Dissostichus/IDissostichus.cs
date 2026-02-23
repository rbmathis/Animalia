namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Dissostichus;

/// <summary>
/// Interface defining characteristics of Dissostichus (genus).
/// </summary>
public interface IDissostichus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
