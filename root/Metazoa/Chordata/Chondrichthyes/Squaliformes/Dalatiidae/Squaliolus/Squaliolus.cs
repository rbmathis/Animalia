using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Squaliolus;

/// <summary>
/// Abstract class for Squaliolus (genus).
/// NCBI TaxId: 862903
/// </summary>
public abstract class Squaliolus : Dalatiidae, ISqualiolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squaliolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862903;

    /// <inheritdoc />
    public virtual string GenusName => "Squaliolus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
