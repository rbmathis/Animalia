namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Trapelus;

/// <summary>
/// Species: Trapelus sanguinolentus
/// NCBI TaxId: 118238
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trapelus_sanguinolentus : Trapelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trapelus sanguinolentus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trapelus_sanguinolentus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 118238;
}
