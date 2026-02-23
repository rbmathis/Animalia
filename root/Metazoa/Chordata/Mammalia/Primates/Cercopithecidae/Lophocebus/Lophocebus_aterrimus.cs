namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Lophocebus;

/// <summary>
/// Species: Lophocebus aterrimus
/// NCBI TaxId: 75566
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophocebus_aterrimus : Lophocebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophocebus aterrimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophocebus_aterrimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75566;
}
