using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Eupleurogrammus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Eupleurogrammus.unclassified_Eupleurogrammus;

/// <summary>
/// Abstract class for unclassified Eupleurogrammus (no rank).
/// NCBI TaxId: 2641294
/// </summary>
public abstract class unclassified_Eupleurogrammus : Eupleurogrammus, Iunclassified_Eupleurogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eupleurogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641294;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eupleurogrammus";
}
