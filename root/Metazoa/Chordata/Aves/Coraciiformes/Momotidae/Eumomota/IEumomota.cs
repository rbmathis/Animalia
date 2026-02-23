namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Eumomota;

/// <summary>
/// Interface defining characteristics of Eumomota (genus).
/// </summary>
public interface IEumomota
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
