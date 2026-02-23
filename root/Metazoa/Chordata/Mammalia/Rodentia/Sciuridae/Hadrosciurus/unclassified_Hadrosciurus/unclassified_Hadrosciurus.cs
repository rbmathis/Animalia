using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Hadrosciurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Hadrosciurus.unclassified_Hadrosciurus;

/// <summary>
/// Abstract class for unclassified Hadrosciurus (no rank).
/// NCBI TaxId: 2986958
/// </summary>
public abstract class unclassified_Hadrosciurus : Hadrosciurus, Iunclassified_Hadrosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hadrosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986958;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hadrosciurus";
}
