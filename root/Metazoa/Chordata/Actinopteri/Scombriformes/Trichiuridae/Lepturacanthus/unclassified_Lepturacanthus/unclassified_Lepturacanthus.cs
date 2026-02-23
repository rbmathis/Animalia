using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Lepturacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Lepturacanthus.unclassified_Lepturacanthus;

/// <summary>
/// Abstract class for unclassified Lepturacanthus (no rank).
/// NCBI TaxId: 2618985
/// </summary>
public abstract class unclassified_Lepturacanthus : Lepturacanthus, Iunclassified_Lepturacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepturacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618985;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepturacanthus";
}
