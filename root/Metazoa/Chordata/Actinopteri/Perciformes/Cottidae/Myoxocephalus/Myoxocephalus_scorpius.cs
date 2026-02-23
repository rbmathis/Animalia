namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Myoxocephalus;

/// <summary>
/// Species: Myoxocephalus scorpius
/// NCBI TaxId: 8097
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myoxocephalus_scorpius : Myoxocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myoxocephalus scorpius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myoxocephalus_scorpius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8097;
}
