using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Dolopichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Dolopichthys.unclassified_Dolopichthys;

/// <summary>
/// Abstract class for unclassified Dolopichthys (no rank).
/// NCBI TaxId: 2649434
/// </summary>
public abstract class unclassified_Dolopichthys : Dolopichthys, Iunclassified_Dolopichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dolopichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649434;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dolopichthys";
}
