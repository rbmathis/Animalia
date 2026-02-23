using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittaculirostris;

/// <summary>
/// Abstract class for Psittaculirostris (genus).
/// NCBI TaxId: 274069
/// </summary>
public abstract class Psittaculirostris : Psittacidae, IPsittaculirostris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittaculirostris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274069;

    /// <inheritdoc />
    public virtual string GenusName => "Psittaculirostris";

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
