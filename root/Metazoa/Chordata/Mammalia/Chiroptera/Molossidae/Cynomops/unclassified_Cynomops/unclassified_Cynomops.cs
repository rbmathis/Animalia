using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Cynomops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Cynomops.unclassified_Cynomops;

/// <summary>
/// Abstract class for unclassified Cynomops (no rank).
/// NCBI TaxId: 2648417
/// </summary>
public abstract class unclassified_Cynomops : Cynomops, Iunclassified_Cynomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648417;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynomops";
}
