using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Troglodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Troglodytes.unclassified_Troglodytes;

/// <summary>
/// Abstract class for unclassified Troglodytes (no rank).
/// NCBI TaxId: 2622456
/// </summary>
public abstract class unclassified_Troglodytes : Troglodytes, Iunclassified_Troglodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Troglodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622456;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Troglodytes";
}
