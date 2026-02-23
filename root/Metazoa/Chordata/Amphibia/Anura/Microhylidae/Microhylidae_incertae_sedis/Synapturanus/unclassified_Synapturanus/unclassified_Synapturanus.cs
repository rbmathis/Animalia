using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Synapturanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhylidae_incertae_sedis.Synapturanus.unclassified_Synapturanus;

/// <summary>
/// Abstract class for unclassified Synapturanus (no rank).
/// NCBI TaxId: 2685508
/// </summary>
public abstract class unclassified_Synapturanus : Synapturanus, Iunclassified_Synapturanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synapturanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685508;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synapturanus";
}
