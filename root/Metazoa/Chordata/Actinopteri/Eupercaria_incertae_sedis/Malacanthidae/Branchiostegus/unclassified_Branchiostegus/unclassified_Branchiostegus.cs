using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Branchiostegus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Malacanthidae.Branchiostegus.unclassified_Branchiostegus;

/// <summary>
/// Abstract class for unclassified Branchiostegus (no rank).
/// NCBI TaxId: 2633706
/// </summary>
public abstract class unclassified_Branchiostegus : Branchiostegus, Iunclassified_Branchiostegus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Branchiostegus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633706;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Branchiostegus";
}
