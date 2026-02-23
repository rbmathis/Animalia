using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pseudohydromys;

/// <summary>
/// Abstract class for Pseudohydromys (genus).
/// NCBI TaxId: 442601
/// </summary>
public abstract class Pseudohydromys : Muridae, IPseudohydromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudohydromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442601;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudohydromys";

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
