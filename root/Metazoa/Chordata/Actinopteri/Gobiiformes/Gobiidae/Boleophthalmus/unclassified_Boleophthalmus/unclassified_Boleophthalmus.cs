using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Boleophthalmus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Boleophthalmus.unclassified_Boleophthalmus;

/// <summary>
/// Abstract class for unclassified Boleophthalmus (no rank).
/// NCBI TaxId: 2639017
/// </summary>
public abstract class unclassified_Boleophthalmus : Boleophthalmus, Iunclassified_Boleophthalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boleophthalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639017;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boleophthalmus";
}
