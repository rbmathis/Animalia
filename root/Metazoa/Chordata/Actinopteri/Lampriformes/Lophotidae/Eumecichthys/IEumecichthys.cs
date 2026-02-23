namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Lophotidae.Eumecichthys;

/// <summary>
/// Interface defining characteristics of Eumecichthys (genus).
/// </summary>
public interface IEumecichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
