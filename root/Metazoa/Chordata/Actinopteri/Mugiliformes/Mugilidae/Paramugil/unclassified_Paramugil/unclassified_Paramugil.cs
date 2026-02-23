using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Paramugil;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Paramugil.unclassified_Paramugil;

/// <summary>
/// Abstract class for unclassified Paramugil (no rank).
/// NCBI TaxId: 3031437
/// </summary>
public abstract class unclassified_Paramugil : Paramugil, Iunclassified_Paramugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paramugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3031437;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paramugil";
}
