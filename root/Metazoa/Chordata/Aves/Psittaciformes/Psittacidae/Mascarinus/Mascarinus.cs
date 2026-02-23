using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Mascarinus;

/// <summary>
/// Abstract class for Mascarinus (genus).
/// NCBI TaxId: 703982
/// </summary>
public abstract class Mascarinus : Psittacidae, IMascarinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mascarinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 703982;

    /// <inheritdoc />
    public virtual string GenusName => "Mascarinus";

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
