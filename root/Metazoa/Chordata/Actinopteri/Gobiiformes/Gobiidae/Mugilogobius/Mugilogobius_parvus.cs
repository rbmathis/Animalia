namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mugilogobius;

/// <summary>
/// Species: Mugilogobius parvus
/// NCBI TaxId: 88202
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mugilogobius_parvus : Mugilogobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mugilogobius parvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mugilogobius_parvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 88202;
}
