namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio cynocephalus x Papio anubis
/// NCBI TaxId: 208510
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_cynocephalus_x_Papio_anubis : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio cynocephalus x Papio anubis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_cynocephalus_x_Papio_anubis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 208510;
}
