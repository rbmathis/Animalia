using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Novaculichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Novaculichthys.unclassified_Novaculichthys;

/// <summary>
/// Abstract class for unclassified Novaculichthys (no rank).
/// NCBI TaxId: 3142705
/// </summary>
public abstract class unclassified_Novaculichthys : Novaculichthys, Iunclassified_Novaculichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Novaculichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3142705;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Novaculichthys";
}
