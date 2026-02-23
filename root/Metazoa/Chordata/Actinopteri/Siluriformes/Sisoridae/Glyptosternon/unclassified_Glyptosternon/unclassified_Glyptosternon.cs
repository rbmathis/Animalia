using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptosternon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Glyptosternon.unclassified_Glyptosternon;

/// <summary>
/// Abstract class for unclassified Glyptosternon (no rank).
/// NCBI TaxId: 2814150
/// </summary>
public abstract class unclassified_Glyptosternon : Glyptosternon, Iunclassified_Glyptosternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Glyptosternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2814150;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Glyptosternon";
}
