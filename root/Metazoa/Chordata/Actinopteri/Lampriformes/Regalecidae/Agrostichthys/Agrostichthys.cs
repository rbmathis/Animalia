using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Regalecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Regalecidae.Agrostichthys;

/// <summary>
/// Abstract class for Agrostichthys (genus).
/// NCBI TaxId: 2696639
/// </summary>
public abstract class Agrostichthys : Regalecidae, IAgrostichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agrostichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696639;

    /// <inheritdoc />
    public virtual string GenusName => "Agrostichthys";

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
