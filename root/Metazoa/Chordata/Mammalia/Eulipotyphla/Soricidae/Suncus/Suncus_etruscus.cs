namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Species: Suncus etruscus
/// NCBI TaxId: 109475
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Suncus_etruscus : Suncus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Suncus etruscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Suncus_etruscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109475;
}
