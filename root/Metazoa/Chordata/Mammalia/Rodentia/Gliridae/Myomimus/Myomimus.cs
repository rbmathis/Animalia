using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Myomimus;

/// <summary>
/// Abstract class for Myomimus (genus).
/// NCBI TaxId: 221693
/// </summary>
public abstract class Myomimus : Gliridae, IMyomimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myomimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221693;

    /// <inheritdoc />
    public virtual string GenusName => "Myomimus";

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
