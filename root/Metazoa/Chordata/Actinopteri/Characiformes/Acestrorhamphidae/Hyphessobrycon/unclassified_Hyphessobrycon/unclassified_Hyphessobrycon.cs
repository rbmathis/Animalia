using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hyphessobrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hyphessobrycon.unclassified_Hyphessobrycon;

/// <summary>
/// Abstract class for unclassified Hyphessobrycon (no rank).
/// NCBI TaxId: 2608181
/// </summary>
public abstract class unclassified_Hyphessobrycon : Hyphessobrycon, Iunclassified_Hyphessobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyphessobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608181;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyphessobrycon";
}
