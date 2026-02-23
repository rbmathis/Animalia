using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Nyctimantis.unclassified_Nyctimantis;

/// <summary>
/// Abstract class for unclassified Nyctimantis (no rank).
/// NCBI TaxId: 2728973
/// </summary>
public abstract class unclassified_Nyctimantis : Nyctimantis, Iunclassified_Nyctimantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctimantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2728973;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctimantis";
}
