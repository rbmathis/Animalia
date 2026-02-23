namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Eumesogrammus;

/// <summary>
/// Interface defining characteristics of Eumesogrammus (genus).
/// </summary>
public interface IEumesogrammus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
