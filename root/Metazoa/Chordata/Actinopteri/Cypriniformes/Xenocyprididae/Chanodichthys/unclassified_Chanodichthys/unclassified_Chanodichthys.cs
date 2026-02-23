using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Chanodichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Chanodichthys.unclassified_Chanodichthys;

/// <summary>
/// Abstract class for unclassified Chanodichthys (no rank).
/// NCBI TaxId: 2645092
/// </summary>
public abstract class unclassified_Chanodichthys : Chanodichthys, Iunclassified_Chanodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chanodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chanodichthys";
}
