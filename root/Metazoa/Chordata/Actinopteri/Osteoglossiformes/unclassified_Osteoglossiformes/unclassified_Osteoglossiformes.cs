using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.unclassified_Osteoglossiformes;

/// <summary>
/// Abstract class for unclassified Osteoglossiformes (no rank).
/// NCBI TaxId: 723963
/// </summary>
public abstract class unclassified_Osteoglossiformes : Osteoglossiformes, Iunclassified_Osteoglossiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteoglossiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723963;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteoglossiformes";
}
