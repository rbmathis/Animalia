namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurista;

/// <summary>
/// Species: Petaurista philippensis
/// NCBI TaxId: 89095
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petaurista_philippensis : Petaurista
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petaurista philippensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petaurista_philippensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89095;
}
