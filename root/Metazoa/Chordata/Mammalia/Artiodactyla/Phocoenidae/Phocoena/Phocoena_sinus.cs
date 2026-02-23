namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Phocoena;

/// <summary>
/// Species: Phocoena sinus
/// NCBI TaxId: 42100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phocoena_sinus : Phocoena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phocoena sinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phocoena_sinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42100;
}
