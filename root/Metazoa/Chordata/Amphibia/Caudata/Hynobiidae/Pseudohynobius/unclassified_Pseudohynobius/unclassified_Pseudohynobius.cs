using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Pseudohynobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Pseudohynobius.unclassified_Pseudohynobius;

/// <summary>
/// Abstract class for unclassified Pseudohynobius (no rank).
/// NCBI TaxId: 2644649
/// </summary>
public abstract class unclassified_Pseudohynobius : Pseudohynobius, Iunclassified_Pseudohynobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudohynobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644649;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudohynobius";
}
