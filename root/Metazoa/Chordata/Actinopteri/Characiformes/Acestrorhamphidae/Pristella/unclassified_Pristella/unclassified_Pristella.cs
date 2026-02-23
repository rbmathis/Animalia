using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Pristella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Pristella.unclassified_Pristella;

/// <summary>
/// Abstract class for unclassified Pristella (no rank).
/// NCBI TaxId: 3101897
/// </summary>
public abstract class unclassified_Pristella : Pristella, Iunclassified_Pristella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristella";
}
