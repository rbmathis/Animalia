using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stereocyclops;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stereocyclops.unclassified_Stereocyclops;

/// <summary>
/// Abstract class for unclassified Stereocyclops (no rank).
/// NCBI TaxId: 2609373
/// </summary>
public abstract class unclassified_Stereocyclops : Stereocyclops, Iunclassified_Stereocyclops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stereocyclops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609373;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stereocyclops";
}
