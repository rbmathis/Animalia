using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Rhodosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Corellidae.Rhodosoma.unclassified_Rhodosoma;

/// <summary>
/// Abstract class for unclassified Rhodosoma (no rank).
/// NCBI TaxId: 3072564
/// </summary>
public abstract class unclassified_Rhodosoma : Rhodosoma, Iunclassified_Rhodosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhodosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3072564;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhodosoma";
}
