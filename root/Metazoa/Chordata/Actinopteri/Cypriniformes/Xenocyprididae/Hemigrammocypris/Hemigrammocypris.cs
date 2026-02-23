using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hemigrammocypris;

/// <summary>
/// Abstract class for Hemigrammocypris (genus).
/// NCBI TaxId: 180930
/// </summary>
public abstract class Hemigrammocypris : Xenocyprididae, IHemigrammocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigrammocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 180930;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigrammocypris";

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
