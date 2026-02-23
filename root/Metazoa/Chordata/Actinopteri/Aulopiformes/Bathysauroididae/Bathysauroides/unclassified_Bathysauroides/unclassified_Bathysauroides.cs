using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauroididae.Bathysauroides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauroididae.Bathysauroides.unclassified_Bathysauroides;

/// <summary>
/// Abstract class for unclassified Bathysauroides (no rank).
/// NCBI TaxId: 3501814
/// </summary>
public abstract class unclassified_Bathysauroides : Bathysauroides, Iunclassified_Bathysauroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bathysauroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3501814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bathysauroides";
}
