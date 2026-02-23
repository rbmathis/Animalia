using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sundasciurus;

/// <summary>
/// Abstract class for Sundasciurus (genus).
/// NCBI TaxId: 226574
/// </summary>
public abstract class Sundasciurus : Sciuridae, ISundasciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sundasciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226574;

    /// <inheritdoc />
    public virtual string GenusName => "Sundasciurus";

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
