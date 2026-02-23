namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus;

/// <summary>
/// Species: Lagopus scotica
/// NCBI TaxId: 359986
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagopus_scotica : Lagopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagopus scotica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagopus_scotica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 359986;
}
