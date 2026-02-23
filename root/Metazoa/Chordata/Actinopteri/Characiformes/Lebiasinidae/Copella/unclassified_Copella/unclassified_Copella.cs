using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Copella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Copella.unclassified_Copella;

/// <summary>
/// Abstract class for unclassified Copella (no rank).
/// NCBI TaxId: 3101832
/// </summary>
public abstract class unclassified_Copella : Copella, Iunclassified_Copella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Copella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101832;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Copella";
}
