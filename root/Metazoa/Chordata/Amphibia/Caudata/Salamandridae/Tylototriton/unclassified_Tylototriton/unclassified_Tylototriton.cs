using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Tylototriton;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Tylototriton.unclassified_Tylototriton;

/// <summary>
/// Abstract class for unclassified Tylototriton (no rank).
/// NCBI TaxId: 2483955
/// </summary>
public abstract class unclassified_Tylototriton : Tylototriton, Iunclassified_Tylototriton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tylototriton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2483955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tylototriton";
}
