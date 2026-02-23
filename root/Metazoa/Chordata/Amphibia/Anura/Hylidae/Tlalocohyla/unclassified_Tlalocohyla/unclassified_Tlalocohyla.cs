using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tlalocohyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tlalocohyla.unclassified_Tlalocohyla;

/// <summary>
/// Abstract class for unclassified Tlalocohyla (no rank).
/// NCBI TaxId: 2919422
/// </summary>
public abstract class unclassified_Tlalocohyla : Tlalocohyla, Iunclassified_Tlalocohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tlalocohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2919422;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tlalocohyla";
}
