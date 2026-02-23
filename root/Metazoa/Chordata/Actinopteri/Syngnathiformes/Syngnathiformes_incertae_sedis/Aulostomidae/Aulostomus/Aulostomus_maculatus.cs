namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae.Aulostomus;

/// <summary>
/// Species: Aulostomus maculatus
/// NCBI TaxId: 150449
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aulostomus_maculatus : Aulostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aulostomus maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aulostomus_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150449;
}
