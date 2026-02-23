namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

/// <summary>
/// Species: Coturnix coturnix
/// NCBI TaxId: 9091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coturnix_coturnix : Coturnix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coturnix coturnix";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coturnix_coturnix";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9091;
}
