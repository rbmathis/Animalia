using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muriculus;

/// <summary>
/// Abstract class for Muriculus (genus).
/// NCBI TaxId: 1465658
/// </summary>
public abstract class Muriculus : Muridae, IMuriculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muriculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1465658;

    /// <inheritdoc />
    public virtual string GenusName => "Muriculus";

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
