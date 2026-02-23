namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeriformes_incertae_sedis.Neolestes;

/// <summary>
/// Species: Neolestes torquatus
/// NCBI TaxId: 749578
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neolestes_torquatus : Neolestes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neolestes torquatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neolestes_torquatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 749578;
}
