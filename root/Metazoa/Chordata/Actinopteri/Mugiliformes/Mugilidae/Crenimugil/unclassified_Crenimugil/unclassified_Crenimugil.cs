using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Crenimugil;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Crenimugil.unclassified_Crenimugil;

/// <summary>
/// Abstract class for unclassified Crenimugil (no rank).
/// NCBI TaxId: 2678930
/// </summary>
public abstract class unclassified_Crenimugil : Crenimugil, Iunclassified_Crenimugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crenimugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2678930;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crenimugil";
}
