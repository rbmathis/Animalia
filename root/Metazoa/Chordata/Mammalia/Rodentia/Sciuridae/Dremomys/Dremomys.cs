using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Dremomys;

/// <summary>
/// Abstract class for Dremomys (genus).
/// NCBI TaxId: 226545
/// </summary>
public abstract class Dremomys : Sciuridae, IDremomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dremomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226545;

    /// <inheritdoc />
    public virtual string GenusName => "Dremomys";

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
