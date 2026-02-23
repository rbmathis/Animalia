using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Hoplostethus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Trachichthyidae.Hoplostethus.unclassified_Hoplostethus;

/// <summary>
/// Abstract class for unclassified Hoplostethus (no rank).
/// NCBI TaxId: 2644163
/// </summary>
public abstract class unclassified_Hoplostethus : Hoplostethus, Iunclassified_Hoplostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644163;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplostethus";
}
