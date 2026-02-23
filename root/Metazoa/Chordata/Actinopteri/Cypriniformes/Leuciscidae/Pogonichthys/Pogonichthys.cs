using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pogonichthys;

/// <summary>
/// Abstract class for Pogonichthys (genus).
/// NCBI TaxId: 86927
/// </summary>
public abstract class Pogonichthys : Leuciscidae, IPogonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86927;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonichthys";

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
