using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Pseudogonatodes;

/// <summary>
/// Abstract class for Pseudogonatodes (genus).
/// NCBI TaxId: 460628
/// </summary>
public abstract class Pseudogonatodes : Sphaerodactylidae, IPseudogonatodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudogonatodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460628;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudogonatodes";

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
