using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae.Pelodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae.Pelodytes.unclassified_Pelodytes;

/// <summary>
/// Abstract class for unclassified Pelodytes (no rank).
/// NCBI TaxId: 2644484
/// </summary>
public abstract class unclassified_Pelodytes : Pelodytes, Iunclassified_Pelodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pelodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644484;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pelodytes";
}
