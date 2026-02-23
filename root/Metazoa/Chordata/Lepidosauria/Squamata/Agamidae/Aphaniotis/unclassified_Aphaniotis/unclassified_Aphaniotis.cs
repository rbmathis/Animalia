using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Aphaniotis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Aphaniotis.unclassified_Aphaniotis;

/// <summary>
/// Abstract class for unclassified Aphaniotis (no rank).
/// NCBI TaxId: 3467896
/// </summary>
public abstract class unclassified_Aphaniotis : Aphaniotis, Iunclassified_Aphaniotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphaniotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467896;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphaniotis";
}
