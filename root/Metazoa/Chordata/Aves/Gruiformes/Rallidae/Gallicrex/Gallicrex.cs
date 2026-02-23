using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Gallicrex;

/// <summary>
/// Abstract class for Gallicrex (genus).
/// NCBI TaxId: 261966
/// </summary>
public abstract class Gallicrex : Rallidae, IGallicrex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallicrex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261966;

    /// <inheritdoc />
    public virtual string GenusName => "Gallicrex";

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
