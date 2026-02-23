using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllodytes.unclassified_Phyllodytes;

/// <summary>
/// Abstract class for unclassified Phyllodytes (no rank).
/// NCBI TaxId: 2621251
/// </summary>
public abstract class unclassified_Phyllodytes : Phyllodytes, Iunclassified_Phyllodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phyllodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621251;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phyllodytes";
}
