using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Gymnocranius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Gymnocranius.unclassified_Gymnocranius;

/// <summary>
/// Abstract class for unclassified Gymnocranius (no rank).
/// NCBI TaxId: 2635486
/// </summary>
public abstract class unclassified_Gymnocranius : Gymnocranius, Iunclassified_Gymnocranius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnocranius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635486;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnocranius";
}
