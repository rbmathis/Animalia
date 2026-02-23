using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muridae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muridae_incertae_sedis.Malpaisomys;

/// <summary>
/// Abstract class for Malpaisomys (genus).
/// NCBI TaxId: 1211275
/// </summary>
public abstract class Malpaisomys : Muridae_incertae_sedis, IMalpaisomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malpaisomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1211275;

    /// <inheritdoc />
    public virtual string GenusName => "Malpaisomys";

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
