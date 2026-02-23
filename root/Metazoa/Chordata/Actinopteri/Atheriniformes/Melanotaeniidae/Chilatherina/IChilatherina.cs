namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Chilatherina;

/// <summary>
/// Interface defining characteristics of Chilatherina (genus).
/// </summary>
public interface IChilatherina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
