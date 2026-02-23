namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Lanioturdus;

/// <summary>
/// Species: Lanioturdus torquatus
/// NCBI TaxId: 272835
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lanioturdus_torquatus : Lanioturdus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lanioturdus torquatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lanioturdus_torquatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 272835;
}
