namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae.Aulostomus;

/// <summary>
/// Species: Aulostomus strigosus
/// NCBI TaxId: 150450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aulostomus_strigosus : Aulostomus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aulostomus strigosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aulostomus_strigosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150450;
}
