namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Eumicrotremus;

/// <summary>
/// Interface defining characteristics of Eumicrotremus (genus).
/// </summary>
public interface IEumicrotremus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
