using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Poptella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Poptella.unclassified_Poptella;

/// <summary>
/// Abstract class for unclassified Poptella (no rank).
/// NCBI TaxId: 2639890
/// </summary>
public abstract class unclassified_Poptella : Poptella, Iunclassified_Poptella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poptella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639890;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poptella";
}
