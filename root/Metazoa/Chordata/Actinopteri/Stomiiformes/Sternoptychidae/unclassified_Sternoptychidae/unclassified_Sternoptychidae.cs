using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.unclassified_Sternoptychidae;

/// <summary>
/// Abstract class for unclassified Sternoptychidae (no rank).
/// NCBI TaxId: 1181459
/// </summary>
public abstract class unclassified_Sternoptychidae : Sternoptychidae, Iunclassified_Sternoptychidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternoptychidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1181459;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternoptychidae";
}
