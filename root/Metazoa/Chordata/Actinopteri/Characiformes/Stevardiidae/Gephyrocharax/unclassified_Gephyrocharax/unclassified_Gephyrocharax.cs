using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Gephyrocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Gephyrocharax.unclassified_Gephyrocharax;

/// <summary>
/// Abstract class for unclassified Gephyrocharax (no rank).
/// NCBI TaxId: 2640482
/// </summary>
public abstract class unclassified_Gephyrocharax : Gephyrocharax, Iunclassified_Gephyrocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gephyrocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640482;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gephyrocharax";
}
