using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Dipus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Dipus.unclassified_Dipus;

/// <summary>
/// Abstract class for unclassified Dipus (no rank).
/// NCBI TaxId: 2632247
/// </summary>
public abstract class unclassified_Dipus : Dipus, Iunclassified_Dipus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dipus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632247;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dipus";
}
