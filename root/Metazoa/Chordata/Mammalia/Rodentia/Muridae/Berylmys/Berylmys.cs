using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Abstract class for Berylmys (genus).
/// NCBI TaxId: 83758
/// </summary>
public abstract class Berylmys : Muridae, IBerylmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Berylmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83758;

    /// <inheritdoc />
    public virtual string GenusName => "Berylmys";

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
