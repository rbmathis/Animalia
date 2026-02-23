using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Heptapterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Heptapterus.unclassified_Heptapterus;

/// <summary>
/// Abstract class for unclassified Heptapterus (no rank).
/// NCBI TaxId: 2630291
/// </summary>
public abstract class unclassified_Heptapterus : Heptapterus, Iunclassified_Heptapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heptapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630291;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heptapterus";
}
