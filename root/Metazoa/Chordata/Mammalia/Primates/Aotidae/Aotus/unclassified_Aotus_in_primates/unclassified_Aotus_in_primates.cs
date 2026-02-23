using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Aotidae.Aotus.unclassified_Aotus_in_primates;

/// <summary>
/// Abstract class for unclassified Aotus (in: primates) (no rank).
/// NCBI TaxId: 2688256
/// </summary>
public abstract class unclassified_Aotus_in_primates : Aotus, Iunclassified_Aotus_in_primates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aotus (in: primates)";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2688256;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aotus_in_primates";
}
