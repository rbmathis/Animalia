using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Inegocia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Inegocia.unclassified_Inegocia;

/// <summary>
/// Abstract class for unclassified Inegocia (no rank).
/// NCBI TaxId: 2763467
/// </summary>
public abstract class unclassified_Inegocia : Inegocia, Iunclassified_Inegocia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Inegocia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2763467;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Inegocia";
}
