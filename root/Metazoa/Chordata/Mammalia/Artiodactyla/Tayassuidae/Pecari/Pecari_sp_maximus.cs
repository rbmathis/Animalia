namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Tayassuidae.Pecari;

/// <summary>
/// Species: Pecari sp. maximus
/// NCBI TaxId: 330703
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pecari_sp_maximus : Pecari
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pecari sp. maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pecari_sp_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 330703;
}
