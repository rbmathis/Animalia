using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Peckoltia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Peckoltia.unclassified_Peckoltia;

/// <summary>
/// Abstract class for unclassified Peckoltia (no rank).
/// NCBI TaxId: 2619408
/// </summary>
public abstract class unclassified_Peckoltia : Peckoltia, Iunclassified_Peckoltia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Peckoltia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619408;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Peckoltia";
}
