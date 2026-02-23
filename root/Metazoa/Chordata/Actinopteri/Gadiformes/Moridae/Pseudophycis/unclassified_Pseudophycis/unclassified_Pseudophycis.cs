using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Pseudophycis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Pseudophycis.unclassified_Pseudophycis;

/// <summary>
/// Abstract class for unclassified Pseudophycis (no rank).
/// NCBI TaxId: 3045601
/// </summary>
public abstract class unclassified_Pseudophycis : Pseudophycis, Iunclassified_Pseudophycis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudophycis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3045601;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudophycis";
}
