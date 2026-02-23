using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Eunymphicus;

/// <summary>
/// Abstract class for Eunymphicus (genus).
/// NCBI TaxId: 119402
/// </summary>
public abstract class Eunymphicus : Psittacidae, IEunymphicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eunymphicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119402;

    /// <inheritdoc />
    public virtual string GenusName => "Eunymphicus";

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
