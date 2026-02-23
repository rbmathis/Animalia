namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Erinaceus;

/// <summary>
/// Species: Erinaceus europaeus
/// NCBI TaxId: 9365
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Erinaceus_europaeus : Erinaceus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Erinaceus europaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Erinaceus_europaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9365;
}
