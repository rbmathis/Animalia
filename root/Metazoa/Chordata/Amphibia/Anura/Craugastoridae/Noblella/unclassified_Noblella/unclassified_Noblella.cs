using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Noblella;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Noblella.unclassified_Noblella;

/// <summary>
/// Abstract class for unclassified Noblella (no rank).
/// NCBI TaxId: 2636399
/// </summary>
public abstract class unclassified_Noblella : Noblella, Iunclassified_Noblella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Noblella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636399;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Noblella";
}
