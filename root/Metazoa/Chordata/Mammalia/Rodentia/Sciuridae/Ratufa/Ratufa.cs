using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ratufa;

/// <summary>
/// Abstract class for Ratufa (genus).
/// NCBI TaxId: 226820
/// </summary>
public abstract class Ratufa : Sciuridae, IRatufa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ratufa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226820;

    /// <inheritdoc />
    public virtual string GenusName => "Ratufa";

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
