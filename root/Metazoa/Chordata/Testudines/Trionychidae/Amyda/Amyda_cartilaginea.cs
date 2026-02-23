namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Amyda;

/// <summary>
/// Species: Amyda cartilaginea
/// NCBI TaxId: 161655
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amyda_cartilaginea : Amyda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amyda cartilaginea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amyda_cartilaginea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161655;
}
