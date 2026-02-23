using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pionopsitta;

/// <summary>
/// Abstract class for Pionopsitta (genus).
/// NCBI TaxId: 285228
/// </summary>
public abstract class Pionopsitta : Psittacidae, IPionopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pionopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 285228;

    /// <inheritdoc />
    public virtual string GenusName => "Pionopsitta";

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
