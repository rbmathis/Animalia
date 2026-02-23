namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lepidogobius;

/// <summary>
/// Species: Lepidogobius lepidus
/// NCBI TaxId: 185746
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidogobius_lepidus : Lepidogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidogobius lepidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidogobius_lepidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 185746;
}
