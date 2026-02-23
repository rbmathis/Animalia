using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Cynomys;

/// <summary>
/// Abstract class for Cynomys (genus).
/// NCBI TaxId: 45478
/// </summary>
public abstract class Cynomys : Sciuridae, ICynomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45478;

    /// <inheritdoc />
    public virtual string GenusName => "Cynomys";

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
