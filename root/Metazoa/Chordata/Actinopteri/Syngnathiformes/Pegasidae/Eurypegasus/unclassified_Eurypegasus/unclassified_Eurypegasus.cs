using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Eurypegasus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Eurypegasus.unclassified_Eurypegasus;

/// <summary>
/// Abstract class for unclassified Eurypegasus (no rank).
/// NCBI TaxId: 2990119
/// </summary>
public abstract class unclassified_Eurypegasus : Eurypegasus, Iunclassified_Eurypegasus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eurypegasus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990119;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eurypegasus";
}
