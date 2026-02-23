using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Moenkhausia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Moenkhausia.unclassified_Moenkhausia;

/// <summary>
/// Abstract class for unclassified Moenkhausia (no rank).
/// NCBI TaxId: 2648590
/// </summary>
public abstract class unclassified_Moenkhausia : Moenkhausia, Iunclassified_Moenkhausia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moenkhausia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648590;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moenkhausia";
}
