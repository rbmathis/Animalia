using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Petaurista;

/// <summary>
/// Abstract class for Petaurista (genus).
/// NCBI TaxId: 55155
/// </summary>
public abstract class Petaurista : Sciuridae, IPetaurista
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petaurista";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55155;

    /// <inheritdoc />
    public virtual string GenusName => "Petaurista";

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
