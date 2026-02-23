namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.Scleropages;

/// <summary>
/// Interface defining characteristics of Scleropages (genus).
/// </summary>
public interface IScleropages
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
