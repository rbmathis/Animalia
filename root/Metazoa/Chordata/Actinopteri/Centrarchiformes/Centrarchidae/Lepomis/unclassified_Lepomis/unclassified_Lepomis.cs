using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Lepomis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Lepomis.unclassified_Lepomis;

/// <summary>
/// Abstract class for unclassified Lepomis (no rank).
/// NCBI TaxId: 2736034
/// </summary>
public abstract class unclassified_Lepomis : Lepomis, Iunclassified_Lepomis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepomis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2736034;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepomis";
}
