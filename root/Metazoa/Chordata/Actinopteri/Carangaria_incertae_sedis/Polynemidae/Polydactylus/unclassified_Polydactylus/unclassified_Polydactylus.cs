using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Polydactylus.unclassified_Polydactylus;

/// <summary>
/// Abstract class for unclassified Polydactylus (no rank).
/// NCBI TaxId: 2621061
/// </summary>
public abstract class unclassified_Polydactylus : Polydactylus, Iunclassified_Polydactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polydactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621061;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polydactylus";
}
