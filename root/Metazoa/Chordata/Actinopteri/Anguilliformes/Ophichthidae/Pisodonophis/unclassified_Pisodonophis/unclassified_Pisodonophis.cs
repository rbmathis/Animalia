using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Pisodonophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Pisodonophis.unclassified_Pisodonophis;

/// <summary>
/// Abstract class for unclassified Pisodonophis (no rank).
/// NCBI TaxId: 2643869
/// </summary>
public abstract class unclassified_Pisodonophis : Pisodonophis, Iunclassified_Pisodonophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pisodonophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643869;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pisodonophis";
}
