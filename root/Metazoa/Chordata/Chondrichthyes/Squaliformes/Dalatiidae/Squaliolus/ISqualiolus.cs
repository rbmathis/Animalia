namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Squaliolus;

/// <summary>
/// Interface defining characteristics of Squaliolus (genus).
/// </summary>
public interface ISqualiolus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
