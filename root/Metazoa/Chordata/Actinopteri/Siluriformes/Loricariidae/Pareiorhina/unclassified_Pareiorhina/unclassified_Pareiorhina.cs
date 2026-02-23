using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pareiorhina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pareiorhina.unclassified_Pareiorhina;

/// <summary>
/// Abstract class for unclassified Pareiorhina (no rank).
/// NCBI TaxId: 2619532
/// </summary>
public abstract class unclassified_Pareiorhina : Pareiorhina, Iunclassified_Pareiorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pareiorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619532;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pareiorhina";
}
