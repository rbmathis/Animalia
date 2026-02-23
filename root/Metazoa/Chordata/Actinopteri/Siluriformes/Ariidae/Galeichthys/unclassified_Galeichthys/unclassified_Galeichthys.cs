using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Galeichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Galeichthys.unclassified_Galeichthys;

/// <summary>
/// Abstract class for unclassified Galeichthys (no rank).
/// NCBI TaxId: 2623093
/// </summary>
public abstract class unclassified_Galeichthys : Galeichthys, Iunclassified_Galeichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galeichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623093;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galeichthys";
}
