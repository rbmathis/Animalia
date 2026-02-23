using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Petropedetes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Petropedetidae.Petropedetes.unclassified_Petropedetes;

/// <summary>
/// Abstract class for unclassified Petropedetes (no rank).
/// NCBI TaxId: 2643425
/// </summary>
public abstract class unclassified_Petropedetes : Petropedetes, Iunclassified_Petropedetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Petropedetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Petropedetes";
}
