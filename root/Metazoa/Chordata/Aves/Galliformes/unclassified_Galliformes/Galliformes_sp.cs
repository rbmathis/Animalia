namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.unclassified_Galliformes;

/// <summary>
/// Species: Galliformes sp.
/// NCBI TaxId: 1857023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galliformes_sp : unclassified_Galliformes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galliformes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galliformes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1857023;
}
