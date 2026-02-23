namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Kraemeriidae.Kraemeria;

/// <summary>
/// Interface defining characteristics of Kraemeria (genus).
/// </summary>
public interface IKraemeria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
