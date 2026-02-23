using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Tomopterna;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Tomopterna.unclassified_Tomopterna;

/// <summary>
/// Abstract class for unclassified Tomopterna (no rank).
/// NCBI TaxId: 2642983
/// </summary>
public abstract class unclassified_Tomopterna : Tomopterna, Iunclassified_Tomopterna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tomopterna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642983;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tomopterna";
}
