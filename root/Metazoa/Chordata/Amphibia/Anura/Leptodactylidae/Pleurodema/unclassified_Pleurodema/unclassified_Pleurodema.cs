using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pleurodema;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pleurodema.unclassified_Pleurodema;

/// <summary>
/// Abstract class for unclassified Pleurodema (no rank).
/// NCBI TaxId: 2644456
/// </summary>
public abstract class unclassified_Pleurodema : Pleurodema, Iunclassified_Pleurodema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pleurodema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644456;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pleurodema";
}
