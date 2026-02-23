namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Mirounga;

/// <summary>
/// Species: Mirounga leonina
/// NCBI TaxId: 9715
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mirounga_leonina : Mirounga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mirounga leonina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mirounga_leonina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9715;
}
