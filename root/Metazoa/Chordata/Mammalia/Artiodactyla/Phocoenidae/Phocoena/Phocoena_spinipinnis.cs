namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Phocoenidae.Phocoena;

/// <summary>
/// Species: Phocoena spinipinnis
/// NCBI TaxId: 27614
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phocoena_spinipinnis : Phocoena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phocoena spinipinnis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phocoena_spinipinnis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27614;
}
