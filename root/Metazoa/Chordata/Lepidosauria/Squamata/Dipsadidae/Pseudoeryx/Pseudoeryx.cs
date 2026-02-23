using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Pseudoeryx;

/// <summary>
/// Abstract class for Pseudoeryx (genus).
/// NCBI TaxId: 121361
/// </summary>
public abstract class Pseudoeryx : Dipsadidae, IPseudoeryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoeryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121361;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoeryx";

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
