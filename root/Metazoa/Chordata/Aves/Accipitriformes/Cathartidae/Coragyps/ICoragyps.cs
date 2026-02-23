namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae.Coragyps;

/// <summary>
/// Interface defining characteristics of Coragyps (genus).
/// </summary>
public interface ICoragyps
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
