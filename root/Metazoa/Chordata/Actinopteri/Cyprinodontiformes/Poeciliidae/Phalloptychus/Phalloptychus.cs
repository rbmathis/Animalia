using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Phalloptychus;

/// <summary>
/// Abstract class for Phalloptychus (genus).
/// NCBI TaxId: 417464
/// </summary>
public abstract class Phalloptychus : Poeciliidae, IPhalloptychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalloptychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417464;

    /// <inheritdoc />
    public virtual string GenusName => "Phalloptychus";

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
