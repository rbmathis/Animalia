namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Species: Acrocephalus baeticatus
/// NCBI TaxId: 68472
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acrocephalus_baeticatus : Acrocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acrocephalus baeticatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acrocephalus_baeticatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 68472;
}
