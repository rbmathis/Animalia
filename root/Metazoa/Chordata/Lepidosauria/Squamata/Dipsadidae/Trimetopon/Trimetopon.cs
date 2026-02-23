using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Trimetopon;

/// <summary>
/// Abstract class for Trimetopon (genus).
/// NCBI TaxId: 758884
/// </summary>
public abstract class Trimetopon : Dipsadidae, ITrimetopon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trimetopon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758884;

    /// <inheritdoc />
    public virtual string GenusName => "Trimetopon";

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
