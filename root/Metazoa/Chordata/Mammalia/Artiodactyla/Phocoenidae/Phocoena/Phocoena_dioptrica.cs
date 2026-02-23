namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Phocoena;

/// <summary>
/// Species: Phocoena dioptrica
/// NCBI TaxId: 34890
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phocoena_dioptrica : Phocoena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phocoena dioptrica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phocoena_dioptrica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34890;
}
