namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Lachesis;

/// <summary>
/// Species: Lachesis muta
/// NCBI TaxId: 8752
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lachesis_muta : Lachesis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lachesis muta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lachesis_muta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8752;
}
