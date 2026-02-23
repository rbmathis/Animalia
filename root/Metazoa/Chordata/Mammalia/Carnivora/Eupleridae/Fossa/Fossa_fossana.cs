namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Fossa;

/// <summary>
/// Species: Fossa fossana
/// NCBI TaxId: 143320
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Fossa_fossana : Fossa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Fossa fossana";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Fossa_fossana";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143320;
}
