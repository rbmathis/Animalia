using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittinus;

/// <summary>
/// Abstract class for Psittinus (genus).
/// NCBI TaxId: 678589
/// </summary>
public abstract class Psittinus : Psittacidae, IPsittinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 678589;

    /// <inheritdoc />
    public virtual string GenusName => "Psittinus";

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
