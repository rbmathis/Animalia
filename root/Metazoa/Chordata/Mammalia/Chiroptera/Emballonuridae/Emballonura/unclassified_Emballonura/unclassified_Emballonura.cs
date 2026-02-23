using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Emballonura;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Emballonura.unclassified_Emballonura;

/// <summary>
/// Abstract class for unclassified Emballonura (no rank).
/// NCBI TaxId: 2630904
/// </summary>
public abstract class unclassified_Emballonura : Emballonura, Iunclassified_Emballonura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Emballonura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630904;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Emballonura";
}
