using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacula;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacula.unclassified_Psittacula;

/// <summary>
/// Abstract class for unclassified Psittacula (no rank).
/// NCBI TaxId: 2621763
/// </summary>
public abstract class unclassified_Psittacula : Psittacula, Iunclassified_Psittacula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psittacula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621763;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psittacula";
}
