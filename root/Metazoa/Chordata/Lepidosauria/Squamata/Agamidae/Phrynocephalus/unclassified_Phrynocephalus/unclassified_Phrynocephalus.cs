using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phrynocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phrynocephalus.unclassified_Phrynocephalus;

/// <summary>
/// Abstract class for unclassified Phrynocephalus (no rank).
/// NCBI TaxId: 2635938
/// </summary>
public abstract class unclassified_Phrynocephalus : Phrynocephalus, Iunclassified_Phrynocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phrynocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635938;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phrynocephalus";
}
