using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Pegusa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Pegusa.unclassified_Pegusa;

/// <summary>
/// Abstract class for unclassified Pegusa (no rank).
/// NCBI TaxId: 2648176
/// </summary>
public abstract class unclassified_Pegusa : Pegusa, Iunclassified_Pegusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pegusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648176;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pegusa";
}
