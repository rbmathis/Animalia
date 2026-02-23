using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Pseudoindotyphlops;

/// <summary>
/// Abstract class for Pseudoindotyphlops (genus).
/// NCBI TaxId: 3148952
/// </summary>
public abstract class Pseudoindotyphlops : Typhlopidae, IPseudoindotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoindotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148952;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoindotyphlops";

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
