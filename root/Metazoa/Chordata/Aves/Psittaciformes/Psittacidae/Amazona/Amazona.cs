using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Amazona;

/// <summary>
/// Abstract class for Amazona (genus).
/// NCBI TaxId: 12929
/// </summary>
public abstract class Amazona : Psittacidae, IAmazona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amazona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 12929;

    /// <inheritdoc />
    public virtual string GenusName => "Amazona";

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
