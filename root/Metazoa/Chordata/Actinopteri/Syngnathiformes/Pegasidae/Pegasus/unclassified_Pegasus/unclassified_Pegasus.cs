using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Pegasus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Pegasidae.Pegasus.unclassified_Pegasus;

/// <summary>
/// Abstract class for unclassified Pegasus (no rank).
/// NCBI TaxId: 2630028
/// </summary>
public abstract class unclassified_Pegasus : Pegasus, Iunclassified_Pegasus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pegasus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630028;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pegasus";
}
