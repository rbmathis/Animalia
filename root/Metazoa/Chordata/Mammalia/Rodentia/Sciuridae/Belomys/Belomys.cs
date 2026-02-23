using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Belomys;

/// <summary>
/// Abstract class for Belomys (genus).
/// NCBI TaxId: 100948
/// </summary>
public abstract class Belomys : Sciuridae, IBelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Belomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100948;

    /// <inheritdoc />
    public virtual string GenusName => "Belomys";

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
