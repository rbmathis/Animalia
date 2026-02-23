namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Turdus;

/// <summary>
/// Species: Turdus torquatus
/// NCBI TaxId: 357595
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Turdus_torquatus : Turdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Turdus torquatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Turdus_torquatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 357595;
}
