using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Zebrias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Zebrias.unclassified_Zebrias;

/// <summary>
/// Abstract class for unclassified Zebrias (no rank).
/// NCBI TaxId: 2638594
/// </summary>
public abstract class unclassified_Zebrias : Zebrias, Iunclassified_Zebrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Zebrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638594;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Zebrias";
}
