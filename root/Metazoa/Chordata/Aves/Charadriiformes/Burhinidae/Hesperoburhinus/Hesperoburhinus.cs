using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Hesperoburhinus;

/// <summary>
/// Abstract class for Hesperoburhinus (genus).
/// NCBI TaxId: 3150779
/// </summary>
public abstract class Hesperoburhinus : Burhinidae, IHesperoburhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hesperoburhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150779;

    /// <inheritdoc />
    public virtual string GenusName => "Hesperoburhinus";

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
