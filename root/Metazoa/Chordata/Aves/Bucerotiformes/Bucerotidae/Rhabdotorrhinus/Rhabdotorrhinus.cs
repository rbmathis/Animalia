using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Rhabdotorrhinus;

/// <summary>
/// Abstract class for Rhabdotorrhinus (genus).
/// NCBI TaxId: 3150778
/// </summary>
public abstract class Rhabdotorrhinus : Bucerotidae, IRhabdotorrhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdotorrhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150778;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdotorrhinus";

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
