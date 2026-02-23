using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neotomys;

/// <summary>
/// Abstract class for Neotomys (genus).
/// NCBI TaxId: 1007657
/// </summary>
public abstract class Neotomys : Cricetidae, INeotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1007657;

    /// <inheritdoc />
    public virtual string GenusName => "Neotomys";

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
