using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Allactaga;

/// <summary>
/// Abstract class for Allactaga (genus).
/// NCBI TaxId: 73860
/// </summary>
public abstract class Allactaga : Dipodidae, IAllactaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allactaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73860;

    /// <inheritdoc />
    public virtual string GenusName => "Allactaga";

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
