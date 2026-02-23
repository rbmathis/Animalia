using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hampala;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hampala.unclassified_Hampala;

/// <summary>
/// Abstract class for unclassified Hampala (no rank).
/// NCBI TaxId: 2649819
/// </summary>
public abstract class unclassified_Hampala : Hampala, Iunclassified_Hampala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hampala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hampala";
}
