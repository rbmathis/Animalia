using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Dasykaluta;

/// <summary>
/// Abstract class for Dasykaluta (genus).
/// NCBI TaxId: 9286
/// </summary>
public abstract class Dasykaluta : Dasyuridae, IDasykaluta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasykaluta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9286;

    /// <inheritdoc />
    public virtual string GenusName => "Dasykaluta";

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
