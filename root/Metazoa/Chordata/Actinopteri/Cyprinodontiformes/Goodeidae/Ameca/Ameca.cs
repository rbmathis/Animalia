using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Ameca;

/// <summary>
/// Abstract class for Ameca (genus).
/// NCBI TaxId: 208323
/// </summary>
public abstract class Ameca : Goodeidae, IAmeca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ameca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208323;

    /// <inheritdoc />
    public virtual string GenusName => "Ameca";

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
