using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Engystomops;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Engystomops.unclassified_Engystomops;

/// <summary>
/// Abstract class for unclassified Engystomops (no rank).
/// NCBI TaxId: 2646049
/// </summary>
public abstract class unclassified_Engystomops : Engystomops, Iunclassified_Engystomops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Engystomops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646049;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Engystomops";
}
