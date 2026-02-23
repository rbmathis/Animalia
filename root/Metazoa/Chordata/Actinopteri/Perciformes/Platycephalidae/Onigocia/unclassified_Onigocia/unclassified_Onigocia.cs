using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Onigocia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Onigocia.unclassified_Onigocia;

/// <summary>
/// Abstract class for unclassified Onigocia (no rank).
/// NCBI TaxId: 2621985
/// </summary>
public abstract class unclassified_Onigocia : Onigocia, Iunclassified_Onigocia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Onigocia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621985;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Onigocia";
}
