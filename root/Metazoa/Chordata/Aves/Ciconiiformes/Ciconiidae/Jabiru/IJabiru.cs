namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Jabiru;

/// <summary>
/// Interface defining characteristics of Jabiru (genus).
/// </summary>
public interface IJabiru
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
