using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Mentocrex;

/// <summary>
/// Abstract class for Mentocrex (genus).
/// NCBI TaxId: 2771525
/// </summary>
public abstract class Mentocrex : Rallidae, IMentocrex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mentocrex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2771525;

    /// <inheritdoc />
    public virtual string GenusName => "Mentocrex";

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
