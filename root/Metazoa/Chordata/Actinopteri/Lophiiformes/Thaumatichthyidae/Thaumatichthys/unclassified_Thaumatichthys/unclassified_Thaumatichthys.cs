using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae.Thaumatichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Thaumatichthyidae.Thaumatichthys.unclassified_Thaumatichthys;

/// <summary>
/// Abstract class for unclassified Thaumatichthys (no rank).
/// NCBI TaxId: 2923221
/// </summary>
public abstract class unclassified_Thaumatichthys : Thaumatichthys, Iunclassified_Thaumatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thaumatichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2923221;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thaumatichthys";
}
