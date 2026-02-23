using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Brachirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Brachirus.unclassified_Brachirus;

/// <summary>
/// Abstract class for unclassified Brachirus (no rank).
/// NCBI TaxId: 2625278
/// </summary>
public abstract class unclassified_Brachirus : Brachirus, Iunclassified_Brachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625278;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachirus";
}
