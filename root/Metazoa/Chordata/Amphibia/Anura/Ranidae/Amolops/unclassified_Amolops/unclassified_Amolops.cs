using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Amolops;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Amolops.unclassified_Amolops;

/// <summary>
/// Abstract class for unclassified Amolops (no rank).
/// NCBI TaxId: 2614044
/// </summary>
public abstract class unclassified_Amolops : Amolops, Iunclassified_Amolops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amolops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2614044;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amolops";
}
