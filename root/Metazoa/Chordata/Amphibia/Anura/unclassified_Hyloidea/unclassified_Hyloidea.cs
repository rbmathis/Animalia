using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Hyloidea;

/// <summary>
/// Abstract class for unclassified Hyloidea (no rank).
/// NCBI TaxId: 491127
/// </summary>
public abstract class unclassified_Hyloidea : Anura, Iunclassified_Hyloidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyloidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491127;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyloidea";
}
