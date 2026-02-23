using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Abstract class for Tamias (genus).
/// NCBI TaxId: 13712
/// </summary>
public abstract class Tamias : Sciuridae, ITamias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tamias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13712;

    /// <inheritdoc />
    public virtual string GenusName => "Tamias";

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
