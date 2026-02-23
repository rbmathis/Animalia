using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Loriculus;

/// <summary>
/// Abstract class for Loriculus (genus).
/// NCBI TaxId: 60470
/// </summary>
public abstract class Loriculus : Psittacidae, ILoriculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loriculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60470;

    /// <inheritdoc />
    public virtual string GenusName => "Loriculus";

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
