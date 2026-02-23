using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Crystallodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Crystallodytes.unclassified_Crystallodytes;

/// <summary>
/// Abstract class for unclassified Crystallodytes (no rank).
/// NCBI TaxId: 2618333
/// </summary>
public abstract class unclassified_Crystallodytes : Crystallodytes, Iunclassified_Crystallodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crystallodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618333;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crystallodytes";
}
