using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Heleioporus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Heleioporus.unclassified_Heleioporus;

/// <summary>
/// Abstract class for unclassified Heleioporus (no rank).
/// NCBI TaxId: 2901428
/// </summary>
public abstract class unclassified_Heleioporus : Heleioporus, Iunclassified_Heleioporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heleioporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2901428;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heleioporus";
}
