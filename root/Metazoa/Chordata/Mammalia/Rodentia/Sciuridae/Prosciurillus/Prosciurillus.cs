using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Prosciurillus;

/// <summary>
/// Abstract class for Prosciurillus (genus).
/// NCBI TaxId: 226566
/// </summary>
public abstract class Prosciurillus : Sciuridae, IProsciurillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prosciurillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226566;

    /// <inheritdoc />
    public virtual string GenusName => "Prosciurillus";

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
