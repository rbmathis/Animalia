using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinella.unclassified_Sardinella;

/// <summary>
/// Abstract class for unclassified Sardinella (no rank).
/// NCBI TaxId: 2638318
/// </summary>
public abstract class unclassified_Sardinella : Sardinella, Iunclassified_Sardinella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sardinella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638318;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sardinella";
}
