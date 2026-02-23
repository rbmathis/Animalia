using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Solea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Solea.unclassified_Solea;

/// <summary>
/// Abstract class for unclassified Solea (no rank).
/// NCBI TaxId: 2646727
/// </summary>
public abstract class unclassified_Solea : Solea, Iunclassified_Solea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Solea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646727;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Solea";
}
