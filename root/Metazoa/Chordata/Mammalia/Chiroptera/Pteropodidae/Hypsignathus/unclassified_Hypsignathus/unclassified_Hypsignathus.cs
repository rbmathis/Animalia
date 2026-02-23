using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Hypsignathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Hypsignathus.unclassified_Hypsignathus;

/// <summary>
/// Abstract class for unclassified Hypsignathus (no rank).
/// NCBI TaxId: 2677420
/// </summary>
public abstract class unclassified_Hypsignathus : Hypsignathus, Iunclassified_Hypsignathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypsignathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677420;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypsignathus";
}
