namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Species: Acrocephalus palustris x Acrocephalus schoenobaenus
/// NCBI TaxId: 864511
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acrocephalus_palustris_x_Acrocephalus_schoenobaenus : Acrocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acrocephalus palustris x Acrocephalus schoenobaenus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acrocephalus_palustris_x_Acrocephalus_schoenobaenus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 864511;
}
