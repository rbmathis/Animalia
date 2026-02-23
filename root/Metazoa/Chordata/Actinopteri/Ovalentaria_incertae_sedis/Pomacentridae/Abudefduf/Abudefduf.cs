using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Abudefduf;

/// <summary>
/// Abstract class for Abudefduf (genus).
/// NCBI TaxId: 36213
/// </summary>
public abstract class Abudefduf : Pomacentridae, IAbudefduf
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abudefduf";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36213;

    /// <inheritdoc />
    public virtual string GenusName => "Abudefduf";

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
