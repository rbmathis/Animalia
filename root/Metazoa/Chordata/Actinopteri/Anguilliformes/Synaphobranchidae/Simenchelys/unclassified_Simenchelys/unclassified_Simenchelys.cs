using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Simenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Simenchelys.unclassified_Simenchelys;

/// <summary>
/// Abstract class for unclassified Simenchelys (no rank).
/// NCBI TaxId: 2875688
/// </summary>
public abstract class unclassified_Simenchelys : Simenchelys, Iunclassified_Simenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Simenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2875688;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Simenchelys";
}
