namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Scoliodon;

/// <summary>
/// Species: Scoliodon sp.
/// NCBI TaxId: 3448021
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scoliodon_sp : Scoliodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scoliodon sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scoliodon_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3448021;
}
