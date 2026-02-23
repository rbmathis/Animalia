using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Phascolosorex;

/// <summary>
/// Abstract class for Phascolosorex (genus).
/// NCBI TaxId: 9294
/// </summary>
public abstract class Phascolosorex : Dasyuridae, IPhascolosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phascolosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9294;

    /// <inheritdoc />
    public virtual string GenusName => "Phascolosorex";

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
