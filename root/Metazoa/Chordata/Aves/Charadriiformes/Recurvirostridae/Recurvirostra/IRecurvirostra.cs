namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Recurvirostra;

/// <summary>
/// Interface defining characteristics of Recurvirostra (genus).
/// </summary>
public interface IRecurvirostra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
