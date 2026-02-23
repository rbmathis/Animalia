namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Avahi;

/// <summary>
/// Species: Avahi meridionalis
/// NCBI TaxId: 3061928
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Avahi_meridionalis : Avahi
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Avahi meridionalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Avahi_meridionalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3061928;
}
