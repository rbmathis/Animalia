using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Aphyocypris;

/// <summary>
/// Abstract class for Aphyocypris (genus).
/// NCBI TaxId: 140594
/// </summary>
public abstract class Aphyocypris : Xenocyprididae, IAphyocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphyocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 140594;

    /// <inheritdoc />
    public virtual string GenusName => "Aphyocypris";

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
