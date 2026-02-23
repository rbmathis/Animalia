namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Rupicapra;

/// <summary>
/// Species: Rupicapra rupicapra
/// NCBI TaxId: 34869
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rupicapra_rupicapra : Rupicapra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rupicapra rupicapra";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rupicapra_rupicapra";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 34869;
}
