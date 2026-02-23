namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Species: Graptemys flavimaculata x Graptemys oculifera
/// NCBI TaxId: 1969997
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Graptemys_flavimaculata_x_Graptemys_oculifera : Graptemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Graptemys flavimaculata x Graptemys oculifera";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Graptemys_flavimaculata_x_Graptemys_oculifera";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1969997;
}
