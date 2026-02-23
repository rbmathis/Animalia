using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Ratabulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Ratabulus.unclassified_Ratabulus;

/// <summary>
/// Abstract class for unclassified Ratabulus (no rank).
/// NCBI TaxId: 2650303
/// </summary>
public abstract class unclassified_Ratabulus : Ratabulus, Iunclassified_Ratabulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ratabulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650303;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ratabulus";
}
