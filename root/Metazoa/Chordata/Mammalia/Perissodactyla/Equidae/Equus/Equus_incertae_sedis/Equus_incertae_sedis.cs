using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus.Equus_incertae_sedis;

/// <summary>
/// Abstract class for Equus incertae sedis (no rank).
/// NCBI TaxId: 1225529
/// </summary>
public abstract class Equus_incertae_sedis : Equus, IEquus_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Equus incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1225529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Equus_incertae_sedis";
}
