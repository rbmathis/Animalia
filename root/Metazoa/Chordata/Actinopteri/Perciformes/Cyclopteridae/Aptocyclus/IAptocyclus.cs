namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Aptocyclus;

/// <summary>
/// Interface defining characteristics of Aptocyclus (genus).
/// </summary>
public interface IAptocyclus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
