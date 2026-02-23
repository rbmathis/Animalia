using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petinomys;

/// <summary>
/// Abstract class for Petinomys (genus).
/// NCBI TaxId: 100946
/// </summary>
public abstract class Petinomys : Sciuridae, IPetinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100946;

    /// <inheritdoc />
    public virtual string GenusName => "Petinomys";

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
