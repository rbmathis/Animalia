using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Acantopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Acantopsis.unclassified_Acantopsis;

/// <summary>
/// Abstract class for unclassified Acantopsis (no rank).
/// NCBI TaxId: 2643596
/// </summary>
public abstract class unclassified_Acantopsis : Acantopsis, Iunclassified_Acantopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acantopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643596;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acantopsis";
}
