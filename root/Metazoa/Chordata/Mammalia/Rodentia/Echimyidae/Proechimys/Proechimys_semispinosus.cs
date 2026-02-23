namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Proechimys;

/// <summary>
/// Species: Proechimys semispinosus
/// NCBI TaxId: 1246547
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Proechimys_semispinosus : Proechimys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Proechimys semispinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Proechimys_semispinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1246547;
}
