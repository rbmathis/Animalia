using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Dasyscopelus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Dasyscopelus.unclassified_Dasyscopelus;

/// <summary>
/// Abstract class for unclassified Dasyscopelus (no rank).
/// NCBI TaxId: 3035890
/// </summary>
public abstract class unclassified_Dasyscopelus : Dasyscopelus, Iunclassified_Dasyscopelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasyscopelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3035890;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasyscopelus";
}
