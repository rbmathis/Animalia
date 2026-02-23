using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Chrysichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Claroteidae.Chrysichthys.unclassified_Chrysichthys;

/// <summary>
/// Abstract class for unclassified Chrysichthys (no rank).
/// NCBI TaxId: 2637524
/// </summary>
public abstract class unclassified_Chrysichthys : Chrysichthys, Iunclassified_Chrysichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chrysichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637524;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chrysichthys";
}
