using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tretanorhinus;

/// <summary>
/// Abstract class for Tretanorhinus (genus).
/// NCBI TaxId: 121373
/// </summary>
public abstract class Tretanorhinus : Dipsadidae, ITretanorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tretanorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121373;

    /// <inheritdoc />
    public virtual string GenusName => "Tretanorhinus";

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
