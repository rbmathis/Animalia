using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ratufa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ratufa.unclassified_Ratufa;

/// <summary>
/// Abstract class for unclassified Ratufa (no rank).
/// NCBI TaxId: 2634602
/// </summary>
public abstract class unclassified_Ratufa : Ratufa, Iunclassified_Ratufa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ratufa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634602;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ratufa";
}
