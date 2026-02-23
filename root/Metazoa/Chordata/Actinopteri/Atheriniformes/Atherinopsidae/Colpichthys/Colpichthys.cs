using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Colpichthys;

/// <summary>
/// Abstract class for Colpichthys (genus).
/// NCBI TaxId: 2137794
/// </summary>
public abstract class Colpichthys : Atherinopsidae, IColpichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Colpichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2137794;

    /// <inheritdoc />
    public virtual string GenusName => "Colpichthys";

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
