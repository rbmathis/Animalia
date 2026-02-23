using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Menidae.Mene;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Menidae.Mene.unclassified_Mene;

/// <summary>
/// Abstract class for unclassified Mene (no rank).
/// NCBI TaxId: 3446436
/// </summary>
public abstract class unclassified_Mene : Mene, Iunclassified_Mene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3446436;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mene";
}
