using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Mulloidichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Mulloidichthys.unclassified_Mulloidichthys;

/// <summary>
/// Abstract class for unclassified Mulloidichthys (no rank).
/// NCBI TaxId: 2622951
/// </summary>
public abstract class unclassified_Mulloidichthys : Mulloidichthys, Iunclassified_Mulloidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mulloidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622951;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mulloidichthys";
}
