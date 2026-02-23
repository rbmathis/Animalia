namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Tachiramantis;

/// <summary>
/// Species: Tachiramantis sp.
/// NCBI TaxId: 3455613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachiramantis_sp : Tachiramantis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachiramantis sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachiramantis_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3455613;
}
