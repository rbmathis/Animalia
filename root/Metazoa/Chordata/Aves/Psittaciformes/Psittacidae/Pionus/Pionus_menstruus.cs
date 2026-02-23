namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pionus;

/// <summary>
/// Species: Pionus menstruus
/// NCBI TaxId: 13214
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pionus_menstruus : Pionus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pionus menstruus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pionus_menstruus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13214;
}
