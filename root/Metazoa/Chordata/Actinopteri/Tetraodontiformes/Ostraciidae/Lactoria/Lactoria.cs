using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Lactoria;

/// <summary>
/// Abstract class for Lactoria (genus).
/// NCBI TaxId: 319756
/// </summary>
public abstract class Lactoria : Ostraciidae, ILactoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lactoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 319756;

    /// <inheritdoc />
    public virtual string GenusName => "Lactoria";

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
