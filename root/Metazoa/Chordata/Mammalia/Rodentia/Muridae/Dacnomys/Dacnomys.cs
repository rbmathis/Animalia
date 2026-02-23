using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dacnomys;

/// <summary>
/// Abstract class for Dacnomys (genus).
/// NCBI TaxId: 332663
/// </summary>
public abstract class Dacnomys : Muridae, IDacnomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dacnomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 332663;

    /// <inheritdoc />
    public virtual string GenusName => "Dacnomys";

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
