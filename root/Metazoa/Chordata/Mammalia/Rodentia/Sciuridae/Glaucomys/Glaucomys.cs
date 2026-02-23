using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Glaucomys;

/// <summary>
/// Abstract class for Glaucomys (genus).
/// NCBI TaxId: 45481
/// </summary>
public abstract class Glaucomys : Sciuridae, IGlaucomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45481;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucomys";

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
