using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurillus;

/// <summary>
/// Abstract class for Sciurillus (genus).
/// NCBI TaxId: 45483
/// </summary>
public abstract class Sciurillus : Sciuridae, ISciurillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciurillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45483;

    /// <inheritdoc />
    public virtual string GenusName => "Sciurillus";

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
