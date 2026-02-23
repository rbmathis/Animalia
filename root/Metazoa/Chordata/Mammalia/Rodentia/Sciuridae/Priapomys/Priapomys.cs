using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Priapomys;

/// <summary>
/// Abstract class for Priapomys (genus).
/// NCBI TaxId: 2883637
/// </summary>
public abstract class Priapomys : Sciuridae, IPriapomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priapomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2883637;

    /// <inheritdoc />
    public virtual string GenusName => "Priapomys";

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
