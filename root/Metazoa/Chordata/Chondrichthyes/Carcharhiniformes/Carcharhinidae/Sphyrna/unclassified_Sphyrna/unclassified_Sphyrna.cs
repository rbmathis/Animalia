using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Sphyrna;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Sphyrna.unclassified_Sphyrna;

/// <summary>
/// Abstract class for unclassified Sphyrna (no rank).
/// NCBI TaxId: 2626607
/// </summary>
public abstract class unclassified_Sphyrna : Sphyrna, Iunclassified_Sphyrna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sphyrna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626607;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sphyrna";
}
