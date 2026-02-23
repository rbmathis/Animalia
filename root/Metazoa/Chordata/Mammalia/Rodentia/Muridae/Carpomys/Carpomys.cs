using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Carpomys;

/// <summary>
/// Abstract class for Carpomys (genus).
/// NCBI TaxId: 349722
/// </summary>
public abstract class Carpomys : Muridae, ICarpomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349722;

    /// <inheritdoc />
    public virtual string GenusName => "Carpomys";

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
