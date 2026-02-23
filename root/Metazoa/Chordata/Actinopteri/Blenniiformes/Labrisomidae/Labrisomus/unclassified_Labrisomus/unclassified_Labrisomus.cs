using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Labrisomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Labrisomus.unclassified_Labrisomus;

/// <summary>
/// Abstract class for unclassified Labrisomus (no rank).
/// NCBI TaxId: 2633250
/// </summary>
public abstract class unclassified_Labrisomus : Labrisomus, Iunclassified_Labrisomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labrisomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633250;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labrisomus";
}
