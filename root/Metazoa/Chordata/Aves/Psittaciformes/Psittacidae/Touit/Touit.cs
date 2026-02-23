using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Touit;

/// <summary>
/// Abstract class for Touit (genus).
/// NCBI TaxId: 458124
/// </summary>
public abstract class Touit : Psittacidae, ITouit
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Touit";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458124;

    /// <inheritdoc />
    public virtual string GenusName => "Touit";

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
