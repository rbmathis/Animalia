using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Pteraclis;

/// <summary>
/// Abstract class for Pteraclis (genus).
/// NCBI TaxId: 1219344
/// </summary>
public abstract class Pteraclis : Bramidae, IPteraclis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteraclis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1219344;

    /// <inheritdoc />
    public virtual string GenusName => "Pteraclis";

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
