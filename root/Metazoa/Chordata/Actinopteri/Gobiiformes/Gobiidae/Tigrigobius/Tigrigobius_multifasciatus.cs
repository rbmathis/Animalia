namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tigrigobius;

/// <summary>
/// Species: Tigrigobius multifasciatus
/// NCBI TaxId: 203335
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tigrigobius_multifasciatus : Tigrigobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tigrigobius multifasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tigrigobius_multifasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 203335;
}
