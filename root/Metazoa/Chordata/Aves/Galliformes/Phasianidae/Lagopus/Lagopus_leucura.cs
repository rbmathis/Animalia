namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus;

/// <summary>
/// Species: Lagopus leucura
/// NCBI TaxId: 30410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagopus_leucura : Lagopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagopus leucura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagopus_leucura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30410;
}
