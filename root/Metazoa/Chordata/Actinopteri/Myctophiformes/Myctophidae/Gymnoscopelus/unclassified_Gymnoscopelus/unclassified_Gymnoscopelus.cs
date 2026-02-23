using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Gymnoscopelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Gymnoscopelus.unclassified_Gymnoscopelus;

/// <summary>
/// Abstract class for unclassified Gymnoscopelus (no rank).
/// NCBI TaxId: 2619881
/// </summary>
public abstract class unclassified_Gymnoscopelus : Gymnoscopelus, Iunclassified_Gymnoscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnoscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619881;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnoscopelus";
}
