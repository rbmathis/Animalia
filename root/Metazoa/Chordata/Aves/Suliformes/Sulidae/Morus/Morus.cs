using AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Sulidae.Morus;

/// <summary>
/// Abstract class for Morus (genus).
/// NCBI TaxId: 37577
/// </summary>
public abstract class Morus : Sulidae, IMorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37577;

    /// <inheritdoc />
    public virtual string GenusName => "Morus";

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
