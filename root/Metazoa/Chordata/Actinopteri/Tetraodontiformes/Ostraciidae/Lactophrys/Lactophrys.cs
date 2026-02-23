using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Lactophrys;

/// <summary>
/// Abstract class for Lactophrys (genus).
/// NCBI TaxId: 303727
/// </summary>
public abstract class Lactophrys : Ostraciidae, ILactophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lactophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303727;

    /// <inheritdoc />
    public virtual string GenusName => "Lactophrys";

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
