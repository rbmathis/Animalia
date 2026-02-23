using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Colubridae_incertae_sedis.Oreocalamus;

/// <summary>
/// Abstract class for Oreocalamus (genus).
/// NCBI TaxId: 46300
/// </summary>
public abstract class Oreocalamus : Colubridae_incertae_sedis, IOreocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46300;

    /// <inheritdoc />
    public virtual string GenusName => "Oreocalamus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
