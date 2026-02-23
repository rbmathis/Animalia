using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Lathamus;

/// <summary>
/// Abstract class for Lathamus (genus).
/// NCBI TaxId: 678568
/// </summary>
public abstract class Lathamus : Psittacidae, ILathamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lathamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 678568;

    /// <inheritdoc />
    public virtual string GenusName => "Lathamus";

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
