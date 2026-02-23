namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Acrocephalus;

/// <summary>
/// Species: Acrocephalus scirpaceus x Acrocephalus palustris
/// NCBI TaxId: 1337066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acrocephalus_scirpaceus_x_Acrocephalus_palustris : Acrocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acrocephalus scirpaceus x Acrocephalus palustris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acrocephalus_scirpaceus_x_Acrocephalus_palustris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1337066;
}
