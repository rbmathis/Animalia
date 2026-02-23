using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Ipnopidae.Ipnops;

/// <summary>
/// Abstract class for Ipnops (genus).
/// NCBI TaxId: 172119
/// </summary>
public abstract class Ipnops : Ipnopidae, IIpnops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ipnops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172119;

    /// <inheritdoc />
    public virtual string GenusName => "Ipnops";

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
