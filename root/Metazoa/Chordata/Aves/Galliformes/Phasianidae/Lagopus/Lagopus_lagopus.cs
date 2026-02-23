namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus;

/// <summary>
/// Species: Lagopus lagopus
/// NCBI TaxId: 52650
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lagopus_lagopus : Lagopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lagopus lagopus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lagopus_lagopus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52650;
}
