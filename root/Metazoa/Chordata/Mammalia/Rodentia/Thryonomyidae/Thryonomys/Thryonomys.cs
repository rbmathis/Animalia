using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.Thryonomys;

/// <summary>
/// Abstract class for Thryonomys (genus).
/// NCBI TaxId: 10168
/// </summary>
public abstract class Thryonomys : Thryonomyidae, IThryonomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thryonomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10168;

    /// <inheritdoc />
    public virtual string GenusName => "Thryonomys";

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
