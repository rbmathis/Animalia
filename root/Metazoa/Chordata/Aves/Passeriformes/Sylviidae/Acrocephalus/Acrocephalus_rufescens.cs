namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Species: Acrocephalus rufescens
/// NCBI TaxId: 126875
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acrocephalus_rufescens : Acrocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acrocephalus rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acrocephalus_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126875;
}
