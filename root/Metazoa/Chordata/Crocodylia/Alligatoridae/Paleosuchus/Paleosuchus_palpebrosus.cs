namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Paleosuchus;

/// <summary>
/// Species: Paleosuchus palpebrosus
/// NCBI TaxId: 84099
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paleosuchus_palpebrosus : Paleosuchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paleosuchus palpebrosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paleosuchus_palpebrosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 84099;
}
