namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus;

/// <summary>
/// Species: Lagopus sp.
/// NCBI TaxId: 2933282
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagopus_sp : Lagopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagopus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagopus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2933282;
}
