using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Leiolepis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Leiolepis.unclassified_Leiolepis;

/// <summary>
/// Abstract class for unclassified Leiolepis (no rank).
/// NCBI TaxId: 2619734
/// </summary>
public abstract class unclassified_Leiolepis : Leiolepis, Iunclassified_Leiolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leiolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619734;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leiolepis";
}
