using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo.unclassified_Bufo;

/// <summary>
/// Abstract class for unclassified Bufo (no rank).
/// NCBI TaxId: 2626360
/// </summary>
public abstract class unclassified_Bufo : Bufo, Iunclassified_Bufo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bufo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626360;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bufo";
}
