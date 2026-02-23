using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Ambloplites;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Ambloplites.unclassified_Ambloplites;

/// <summary>
/// Abstract class for unclassified Ambloplites (no rank).
/// NCBI TaxId: 2618446
/// </summary>
public abstract class unclassified_Ambloplites : Ambloplites, Iunclassified_Ambloplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ambloplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618446;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ambloplites";
}
