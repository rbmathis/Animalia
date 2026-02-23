namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pionus;

/// <summary>
/// Species: Pionus cyanescens
/// NCBI TaxId: 458126
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pionus_cyanescens : Pionus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pionus cyanescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pionus_cyanescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458126;
}
