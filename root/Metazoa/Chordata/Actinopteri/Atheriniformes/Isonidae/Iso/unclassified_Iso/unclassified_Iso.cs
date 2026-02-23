using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Isonidae.Iso;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Isonidae.Iso.unclassified_Iso;

/// <summary>
/// Abstract class for unclassified Iso (no rank).
/// NCBI TaxId: 2625801
/// </summary>
public abstract class unclassified_Iso : Iso, Iunclassified_Iso
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Iso";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625801;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Iso";
}
