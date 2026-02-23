namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Dama;

/// <summary>
/// Species: Dama sp.
/// NCBI TaxId: 66310
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dama_sp : Dama
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dama sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dama_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66310;
}
