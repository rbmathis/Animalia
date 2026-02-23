namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

/// <summary>
/// Species: Agapornis fischeri x Agapornis personatus
/// NCBI TaxId: 2606407
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Agapornis_fischeri_x_Agapornis_personatus : Agapornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Agapornis fischeri x Agapornis personatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Agapornis_fischeri_x_Agapornis_personatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2606407;
}
