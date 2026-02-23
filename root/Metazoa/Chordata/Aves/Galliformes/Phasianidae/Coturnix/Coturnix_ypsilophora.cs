namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

/// <summary>
/// Species: Coturnix ypsilophora
/// NCBI TaxId: 2497800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coturnix_ypsilophora : Coturnix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coturnix ypsilophora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coturnix_ypsilophora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2497800;
}
