using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Iconisemion;

/// <summary>
/// Abstract class for Iconisemion (genus).
/// NCBI TaxId: 2175180
/// </summary>
public abstract class Iconisemion : Nothobranchiidae, IIconisemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iconisemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2175180;

    /// <inheritdoc />
    public virtual string GenusName => "Iconisemion";

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
