using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Odontesthes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Odontesthes.unclassified_Odontesthes;

/// <summary>
/// Abstract class for unclassified Odontesthes (no rank).
/// NCBI TaxId: 2620044
/// </summary>
public abstract class unclassified_Odontesthes : Odontesthes, Iunclassified_Odontesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620044;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontesthes";
}
