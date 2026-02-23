using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Rhinichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Rhinichthys.unclassified_Rhinichthys;

/// <summary>
/// Abstract class for unclassified Rhinichthys (no rank).
/// NCBI TaxId: 2624154
/// </summary>
public abstract class unclassified_Rhinichthys : Rhinichthys, Iunclassified_Rhinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624154;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinichthys";
}
