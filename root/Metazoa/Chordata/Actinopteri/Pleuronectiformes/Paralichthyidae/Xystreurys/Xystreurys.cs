using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Xystreurys;

/// <summary>
/// Abstract class for Xystreurys (genus).
/// NCBI TaxId: 195659
/// </summary>
public abstract class Xystreurys : Paralichthyidae, IXystreurys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xystreurys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195659;

    /// <inheritdoc />
    public virtual string GenusName => "Xystreurys";

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
