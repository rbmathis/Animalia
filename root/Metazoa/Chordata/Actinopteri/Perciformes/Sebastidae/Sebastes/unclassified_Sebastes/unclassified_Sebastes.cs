using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Sebastes.unclassified_Sebastes;

/// <summary>
/// Abstract class for unclassified Sebastes (no rank).
/// NCBI TaxId: 2625963
/// </summary>
public abstract class unclassified_Sebastes : Sebastes, Iunclassified_Sebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625963;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sebastes";
}
