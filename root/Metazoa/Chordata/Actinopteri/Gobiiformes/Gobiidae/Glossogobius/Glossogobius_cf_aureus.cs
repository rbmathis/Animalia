namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Glossogobius;

/// <summary>
/// Species: Glossogobius cf. aureus
/// NCBI TaxId: 3072493
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glossogobius_cf_aureus : Glossogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glossogobius cf. aureus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glossogobius_cf_aureus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3072493;
}
