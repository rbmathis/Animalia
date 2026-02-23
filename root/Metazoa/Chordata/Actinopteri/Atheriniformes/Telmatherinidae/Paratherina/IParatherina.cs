namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Paratherina;

/// <summary>
/// Interface defining characteristics of Paratherina (genus).
/// </summary>
public interface IParatherina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
