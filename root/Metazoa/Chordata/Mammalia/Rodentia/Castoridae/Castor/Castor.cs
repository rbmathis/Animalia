using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae.Castor;

/// <summary>
/// Abstract class for Castor (genus).
/// NCBI TaxId: 10184
/// </summary>
public abstract class Castor : Castoridae, ICastor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Castor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10184;

    /// <inheritdoc />
    public virtual string GenusName => "Castor";

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
