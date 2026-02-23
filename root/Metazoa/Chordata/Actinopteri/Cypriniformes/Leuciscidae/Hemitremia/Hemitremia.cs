using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Hemitremia;

/// <summary>
/// Abstract class for Hemitremia (genus).
/// NCBI TaxId: 67542
/// </summary>
public abstract class Hemitremia : Leuciscidae, IHemitremia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemitremia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 67542;

    /// <inheritdoc />
    public virtual string GenusName => "Hemitremia";

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
