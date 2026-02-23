using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Himantolophidae.Himantolophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Himantolophidae.Himantolophus.unclassified_Himantolophus;

/// <summary>
/// Abstract class for unclassified Himantolophus (no rank).
/// NCBI TaxId: 2619608
/// </summary>
public abstract class unclassified_Himantolophus : Himantolophus, Iunclassified_Himantolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Himantolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619608;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Himantolophus";
}
