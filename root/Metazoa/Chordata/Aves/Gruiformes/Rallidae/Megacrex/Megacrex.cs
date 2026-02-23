using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Megacrex;

/// <summary>
/// Abstract class for Megacrex (genus).
/// NCBI TaxId: 54481
/// </summary>
public abstract class Megacrex : Rallidae, IMegacrex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megacrex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54481;

    /// <inheritdoc />
    public virtual string GenusName => "Megacrex";

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
