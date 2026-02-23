using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Promethichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Promethichthys.unclassified_Promethichthys;

/// <summary>
/// Abstract class for unclassified Promethichthys (no rank).
/// NCBI TaxId: 2643406
/// </summary>
public abstract class unclassified_Promethichthys : Promethichthys, Iunclassified_Promethichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Promethichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643406;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Promethichthys";
}
