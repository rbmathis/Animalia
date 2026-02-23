using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Ketengus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Ketengus.unclassified_Ketengus;

/// <summary>
/// Abstract class for unclassified Ketengus (no rank).
/// NCBI TaxId: 2619152
/// </summary>
public abstract class unclassified_Ketengus : Ketengus, Iunclassified_Ketengus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ketengus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619152;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ketengus";
}
