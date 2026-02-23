using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.unclassified_Acipenseriformes;

/// <summary>
/// Abstract class for unclassified Acipenseriformes (no rank).
/// NCBI TaxId: 732566
/// </summary>
public abstract class unclassified_Acipenseriformes : Acipenseriformes, Iunclassified_Acipenseriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acipenseriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 732566;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acipenseriformes";
}
