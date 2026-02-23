using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Stolephorus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Stolephorus.unclassified_Stolephorus;

/// <summary>
/// Abstract class for unclassified Stolephorus (no rank).
/// NCBI TaxId: 2642912
/// </summary>
public abstract class unclassified_Stolephorus : Stolephorus, Iunclassified_Stolephorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stolephorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642912;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stolephorus";
}
