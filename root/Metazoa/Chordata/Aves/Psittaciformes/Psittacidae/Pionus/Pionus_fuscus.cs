namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pionus;

/// <summary>
/// Species: Pionus fuscus
/// NCBI TaxId: 303320
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pionus_fuscus : Pionus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pionus fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pionus_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 303320;
}
