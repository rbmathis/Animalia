using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Abstract class for Lepus (genus).
/// NCBI TaxId: 9980
/// </summary>
public abstract class Lepus : Leporidae, ILepus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9980;

    /// <inheritdoc />
    public virtual string GenusName => "Lepus";

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
