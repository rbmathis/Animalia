using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Homalopsidae.Pseudoferania;

/// <summary>
/// Abstract class for Pseudoferania (genus).
/// NCBI TaxId: 1401516
/// </summary>
public abstract class Pseudoferania : Homalopsidae, IPseudoferania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoferania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1401516;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoferania";

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
