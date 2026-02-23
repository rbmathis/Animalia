namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Phyllonastes;

/// <summary>
/// Species: Phyllonastes sp.
/// NCBI TaxId: 3405127
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllonastes_sp : Phyllonastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllonastes sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllonastes_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3405127;
}
