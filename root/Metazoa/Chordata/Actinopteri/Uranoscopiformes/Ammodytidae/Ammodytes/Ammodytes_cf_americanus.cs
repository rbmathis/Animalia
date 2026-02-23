namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytes;

/// <summary>
/// Species: Ammodytes cf. americanus
/// NCBI TaxId: 184216
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ammodytes_cf_americanus : Ammodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ammodytes cf. americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ammodytes_cf_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184216;
}
