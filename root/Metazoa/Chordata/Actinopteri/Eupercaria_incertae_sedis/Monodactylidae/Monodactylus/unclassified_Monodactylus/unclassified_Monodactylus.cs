using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Monodactylidae.Monodactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Monodactylidae.Monodactylus.unclassified_Monodactylus;

/// <summary>
/// Abstract class for unclassified Monodactylus (no rank).
/// NCBI TaxId: 2638685
/// </summary>
public abstract class unclassified_Monodactylus : Monodactylus, Iunclassified_Monodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638685;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monodactylus";
}
