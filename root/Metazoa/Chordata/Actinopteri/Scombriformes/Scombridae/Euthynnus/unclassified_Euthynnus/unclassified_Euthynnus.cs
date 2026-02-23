using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Euthynnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Euthynnus.unclassified_Euthynnus;

/// <summary>
/// Abstract class for unclassified Euthynnus (no rank).
/// NCBI TaxId: 2624030
/// </summary>
public abstract class unclassified_Euthynnus : Euthynnus, Iunclassified_Euthynnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euthynnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624030;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euthynnus";
}
