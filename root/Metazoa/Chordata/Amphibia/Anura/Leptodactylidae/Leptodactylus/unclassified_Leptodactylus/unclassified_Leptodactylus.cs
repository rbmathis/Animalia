using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus.unclassified_Leptodactylus;

/// <summary>
/// Abstract class for unclassified Leptodactylus (no rank).
/// NCBI TaxId: 2648520
/// </summary>
public abstract class unclassified_Leptodactylus : Leptodactylus, Iunclassified_Leptodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648520;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptodactylus";
}
