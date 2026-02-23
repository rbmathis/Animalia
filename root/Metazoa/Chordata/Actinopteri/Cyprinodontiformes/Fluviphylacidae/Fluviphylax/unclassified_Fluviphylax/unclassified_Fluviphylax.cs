using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fluviphylacidae.Fluviphylax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fluviphylacidae.Fluviphylax.unclassified_Fluviphylax;

/// <summary>
/// Abstract class for unclassified Fluviphylax (no rank).
/// NCBI TaxId: 2685129
/// </summary>
public abstract class unclassified_Fluviphylax : Fluviphylax, Iunclassified_Fluviphylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Fluviphylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685129;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Fluviphylax";
}
