using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Scyliorhinus;

/// <summary>
/// Abstract class for Scyliorhinus (genus).
/// NCBI TaxId: 7829
/// </summary>
public abstract class Scyliorhinus : Scyliorhinidae, IScyliorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scyliorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7829;

    /// <inheritdoc />
    public virtual string GenusName => "Scyliorhinus";

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
