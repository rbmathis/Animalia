using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Lorius;

/// <summary>
/// Abstract class for Lorius (genus).
/// NCBI TaxId: 13113
/// </summary>
public abstract class Lorius : Psittaculidae, ILorius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lorius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13113;

    /// <inheritdoc />
    public virtual string GenusName => "Lorius";

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
