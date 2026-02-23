namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

/// <summary>
/// Species: Pithecia sp.
/// NCBI TaxId: 1758237
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pithecia_sp : Pithecia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pithecia sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pithecia_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1758237;
}
