namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Hemigrammocharax;

/// <summary>
/// Interface defining characteristics of Hemigrammocharax (genus).
/// </summary>
public interface IHemigrammocharax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
