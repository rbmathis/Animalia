using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pezoporus;

/// <summary>
/// Abstract class for Pezoporus (genus).
/// NCBI TaxId: 35539
/// </summary>
public abstract class Pezoporus : Psittacidae, IPezoporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pezoporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35539;

    /// <inheritdoc />
    public virtual string GenusName => "Pezoporus";

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
