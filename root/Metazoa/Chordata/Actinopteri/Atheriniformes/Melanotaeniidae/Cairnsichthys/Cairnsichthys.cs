using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Melanotaeniidae.Cairnsichthys;

/// <summary>
/// Abstract class for Cairnsichthys (genus).
/// NCBI TaxId: 238737
/// </summary>
public abstract class Cairnsichthys : Melanotaeniidae, ICairnsichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cairnsichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238737;

    /// <inheritdoc />
    public virtual string GenusName => "Cairnsichthys";

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
