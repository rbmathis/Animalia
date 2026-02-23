namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

/// <summary>
/// Species: Osteocephalus leprieurii
/// NCBI TaxId: 279980
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteocephalus_leprieurii : Osteocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteocephalus leprieurii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteocephalus_leprieurii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279980;
}
