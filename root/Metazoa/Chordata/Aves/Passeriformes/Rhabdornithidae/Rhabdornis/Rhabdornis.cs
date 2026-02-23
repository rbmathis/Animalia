using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhabdornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhabdornithidae.Rhabdornis;

/// <summary>
/// Abstract class for Rhabdornis (genus).
/// NCBI TaxId: 237437
/// </summary>
public abstract class Rhabdornis : Rhabdornithidae, IRhabdornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237437;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdornis";

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
