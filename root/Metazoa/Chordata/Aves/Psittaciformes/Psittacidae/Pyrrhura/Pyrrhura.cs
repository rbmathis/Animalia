using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pyrrhura;

/// <summary>
/// Abstract class for Pyrrhura (genus).
/// NCBI TaxId: 51909
/// </summary>
public abstract class Pyrrhura : Psittacidae, IPyrrhura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrrhura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51909;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrrhura";

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
