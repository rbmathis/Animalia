namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Bassariscus;

/// <summary>
/// Species: Bassariscus sumichrasti
/// NCBI TaxId: 392507
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bassariscus_sumichrasti : Bassariscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bassariscus sumichrasti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bassariscus_sumichrasti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 392507;
}
