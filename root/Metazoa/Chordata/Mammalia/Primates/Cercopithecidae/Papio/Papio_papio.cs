namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio papio
/// NCBI TaxId: 100937
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_papio : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio papio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_papio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100937;
}
