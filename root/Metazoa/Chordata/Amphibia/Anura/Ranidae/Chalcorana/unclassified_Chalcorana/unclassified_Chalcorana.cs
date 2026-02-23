using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Chalcorana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Chalcorana.unclassified_Chalcorana;

/// <summary>
/// Abstract class for unclassified Chalcorana (no rank).
/// NCBI TaxId: 3126059
/// </summary>
public abstract class unclassified_Chalcorana : Chalcorana, Iunclassified_Chalcorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chalcorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3126059;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chalcorana";
}
