namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys oculifera
/// NCBI TaxId: 33569
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_oculifera : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys oculifera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_oculifera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33569;
}
