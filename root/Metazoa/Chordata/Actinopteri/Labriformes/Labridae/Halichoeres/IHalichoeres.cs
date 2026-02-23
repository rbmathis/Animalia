namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Halichoeres;

/// <summary>
/// Interface defining characteristics of Halichoeres (genus).
/// </summary>
public interface IHalichoeres
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
