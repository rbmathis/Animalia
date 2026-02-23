using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ophioblennius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Ophioblennius.unclassified_Ophioblennius;

/// <summary>
/// Abstract class for unclassified Ophioblennius (no rank).
/// NCBI TaxId: 2626071
/// </summary>
public abstract class unclassified_Ophioblennius : Ophioblennius, Iunclassified_Ophioblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophioblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophioblennius";
}
