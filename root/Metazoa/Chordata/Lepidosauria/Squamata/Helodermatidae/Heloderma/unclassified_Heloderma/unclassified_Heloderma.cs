using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Helodermatidae.Heloderma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Helodermatidae.Heloderma.unclassified_Heloderma;

/// <summary>
/// Abstract class for unclassified Heloderma (no rank).
/// NCBI TaxId: 2640747
/// </summary>
public abstract class unclassified_Heloderma : Heloderma, Iunclassified_Heloderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heloderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640747;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heloderma";
}
