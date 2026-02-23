using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae.Pseudomugil;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae.Pseudomugil.unclassified_Pseudomugil;

/// <summary>
/// Abstract class for unclassified Pseudomugil (no rank).
/// NCBI TaxId: 3240755
/// </summary>
public abstract class unclassified_Pseudomugil : Pseudomugil, Iunclassified_Pseudomugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudomugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3240755;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudomugil";
}
