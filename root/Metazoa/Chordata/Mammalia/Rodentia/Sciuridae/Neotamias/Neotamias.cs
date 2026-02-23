using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Neotamias;

/// <summary>
/// Abstract class for Neotamias (genus).
/// NCBI TaxId: 29133
/// </summary>
public abstract class Neotamias : Sciuridae, INeotamias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neotamias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29133;

    /// <inheritdoc />
    public virtual string GenusName => "Neotamias";

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
