using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Blenniella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Blenniella.unclassified_Blenniella;

/// <summary>
/// Abstract class for unclassified Blenniella (no rank).
/// NCBI TaxId: 2633543
/// </summary>
public abstract class unclassified_Blenniella : Blenniella, Iunclassified_Blenniella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blenniella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633543;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blenniella";
}
