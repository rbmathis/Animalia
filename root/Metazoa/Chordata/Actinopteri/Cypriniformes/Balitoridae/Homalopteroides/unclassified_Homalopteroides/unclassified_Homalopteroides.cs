using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homalopteroides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Homalopteroides.unclassified_Homalopteroides;

/// <summary>
/// Abstract class for unclassified Homalopteroides (no rank).
/// NCBI TaxId: 2769392
/// </summary>
public abstract class unclassified_Homalopteroides : Homalopteroides, Iunclassified_Homalopteroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Homalopteroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2769392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Homalopteroides";
}
