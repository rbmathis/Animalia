using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Basilichthys;

/// <summary>
/// Abstract class for Basilichthys (genus).
/// NCBI TaxId: 461497
/// </summary>
public abstract class Basilichthys : Atherinopsidae, IBasilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Basilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461497;

    /// <inheritdoc />
    public virtual string GenusName => "Basilichthys";

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
