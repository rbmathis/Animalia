using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Paratelmatobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Paratelmatobius.unclassified_Paratelmatobius;

/// <summary>
/// Abstract class for unclassified Paratelmatobius (no rank).
/// NCBI TaxId: 2633517
/// </summary>
public abstract class unclassified_Paratelmatobius : Paratelmatobius, Iunclassified_Paratelmatobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paratelmatobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633517;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paratelmatobius";
}
