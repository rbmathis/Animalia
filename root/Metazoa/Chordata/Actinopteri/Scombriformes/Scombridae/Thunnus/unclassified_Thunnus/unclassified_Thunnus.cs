using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Thunnus.unclassified_Thunnus;

/// <summary>
/// Abstract class for unclassified Thunnus (no rank).
/// NCBI TaxId: 2628853
/// </summary>
public abstract class unclassified_Thunnus : Thunnus, Iunclassified_Thunnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thunnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628853;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thunnus";
}
