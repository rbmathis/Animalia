using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Gasteropelecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Gasteropelecus.unclassified_Gasteropelecus;

/// <summary>
/// Abstract class for unclassified Gasteropelecus (no rank).
/// NCBI TaxId: 2631434
/// </summary>
public abstract class unclassified_Gasteropelecus : Gasteropelecus, Iunclassified_Gasteropelecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gasteropelecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gasteropelecus";
}
