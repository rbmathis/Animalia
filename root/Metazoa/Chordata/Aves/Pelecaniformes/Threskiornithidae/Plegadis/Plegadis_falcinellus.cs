namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Threskiornithidae.Plegadis;

/// <summary>
/// Species: Plegadis falcinellus
/// NCBI TaxId: 52788
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Plegadis_falcinellus : Plegadis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Plegadis falcinellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Plegadis_falcinellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52788;
}
