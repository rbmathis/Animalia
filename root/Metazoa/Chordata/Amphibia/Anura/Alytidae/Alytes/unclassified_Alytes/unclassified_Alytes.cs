using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Alytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Alytes.unclassified_Alytes;

/// <summary>
/// Abstract class for unclassified Alytes (no rank).
/// NCBI TaxId: 2648405
/// </summary>
public abstract class unclassified_Alytes : Alytes, Iunclassified_Alytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648405;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alytes";
}
