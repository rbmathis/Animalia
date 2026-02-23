using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Pterycombus;

/// <summary>
/// Abstract class for Pterycombus (genus).
/// NCBI TaxId: 443807
/// </summary>
public abstract class Pterycombus : Bramidae, IPterycombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterycombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443807;

    /// <inheritdoc />
    public virtual string GenusName => "Pterycombus";

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
