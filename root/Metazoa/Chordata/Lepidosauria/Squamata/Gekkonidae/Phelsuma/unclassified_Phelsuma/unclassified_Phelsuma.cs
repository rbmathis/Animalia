using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Phelsuma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Phelsuma.unclassified_Phelsuma;

/// <summary>
/// Abstract class for unclassified Phelsuma (no rank).
/// NCBI TaxId: 2622648
/// </summary>
public abstract class unclassified_Phelsuma : Phelsuma, Iunclassified_Phelsuma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phelsuma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622648;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phelsuma";
}
