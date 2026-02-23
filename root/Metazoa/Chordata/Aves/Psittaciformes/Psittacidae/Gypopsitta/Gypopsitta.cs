using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Gypopsitta;

/// <summary>
/// Abstract class for Gypopsitta (genus).
/// NCBI TaxId: 303321
/// </summary>
public abstract class Gypopsitta : Psittacidae, IGypopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gypopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303321;

    /// <inheritdoc />
    public virtual string GenusName => "Gypopsitta";

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
