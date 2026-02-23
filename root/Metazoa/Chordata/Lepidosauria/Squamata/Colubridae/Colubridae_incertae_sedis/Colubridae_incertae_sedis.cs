using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis;

/// <summary>
/// Abstract class for Colubridae incertae sedis (no rank).
/// NCBI TaxId: 224893
/// </summary>
public abstract class Colubridae_incertae_sedis : Colubridae, IColubridae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colubridae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Colubridae_incertae_sedis";
}
