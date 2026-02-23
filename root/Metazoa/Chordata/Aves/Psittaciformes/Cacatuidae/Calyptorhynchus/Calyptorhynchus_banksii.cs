namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Calyptorhynchus;

/// <summary>
/// Species: Calyptorhynchus banksii
/// NCBI TaxId: 35551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calyptorhynchus_banksii : Calyptorhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calyptorhynchus banksii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calyptorhynchus_banksii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 35551;
}
