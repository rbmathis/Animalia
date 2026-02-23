using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Burhinidae.Burhinus;

/// <summary>
/// Abstract class for Burhinus (genus).
/// NCBI TaxId: 85104
/// </summary>
public abstract class Burhinus : Burhinidae, IBurhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Burhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85104;

    /// <inheritdoc />
    public virtual string GenusName => "Burhinus";

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
