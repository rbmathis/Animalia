using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Lobocheilos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Lobocheilos.unclassified_Lobocheilos;

/// <summary>
/// Abstract class for unclassified Lobocheilos (no rank).
/// NCBI TaxId: 2634410
/// </summary>
public abstract class unclassified_Lobocheilos : Lobocheilos, Iunclassified_Lobocheilos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lobocheilos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lobocheilos";
}
