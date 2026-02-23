using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Osteoglossidae.unclassified_Osteoglossidae;

/// <summary>
/// Abstract class for unclassified Osteoglossidae (no rank).
/// NCBI TaxId: 1853214
/// </summary>
public abstract class unclassified_Osteoglossidae : Osteoglossidae, Iunclassified_Osteoglossidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteoglossidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1853214;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteoglossidae";
}
