namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

/// <summary>
/// Species: Hylarana cf. novaeguinea
/// NCBI TaxId: 3085205
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylarana_cf_novaeguinea : Hylarana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylarana cf. novaeguinea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylarana_cf_novaeguinea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3085205;
}
