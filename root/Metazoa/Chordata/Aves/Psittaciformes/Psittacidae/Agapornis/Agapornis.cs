using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

/// <summary>
/// Abstract class for Agapornis (genus).
/// NCBI TaxId: 60461
/// </summary>
public abstract class Agapornis : Psittacidae, IAgapornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agapornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 60461;

    /// <inheritdoc />
    public virtual string GenusName => "Agapornis";

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
