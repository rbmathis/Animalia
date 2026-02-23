using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Paralaudakia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Paralaudakia.unclassified_Paralaudakia;

/// <summary>
/// Abstract class for unclassified Paralaudakia (no rank).
/// NCBI TaxId: 2620018
/// </summary>
public abstract class unclassified_Paralaudakia : Paralaudakia, Iunclassified_Paralaudakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralaudakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620018;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralaudakia";
}
