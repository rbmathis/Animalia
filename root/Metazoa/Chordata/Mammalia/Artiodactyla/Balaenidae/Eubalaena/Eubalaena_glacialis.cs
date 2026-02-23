namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Balaenidae.Eubalaena;

/// <summary>
/// Species: Eubalaena glacialis
/// NCBI TaxId: 27606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eubalaena_glacialis : Eubalaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eubalaena glacialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eubalaena_glacialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27606;
}
