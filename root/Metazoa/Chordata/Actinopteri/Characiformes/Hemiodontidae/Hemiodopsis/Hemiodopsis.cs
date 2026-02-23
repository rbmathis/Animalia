using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Hemiodopsis;

/// <summary>
/// Abstract class for Hemiodopsis (genus).
/// NCBI TaxId: 270555
/// </summary>
public abstract class Hemiodopsis : Hemiodontidae, IHemiodopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiodopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270555;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiodopsis";

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
