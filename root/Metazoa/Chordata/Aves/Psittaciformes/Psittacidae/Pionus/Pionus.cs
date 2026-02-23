using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Pionus;

/// <summary>
/// Abstract class for Pionus (genus).
/// NCBI TaxId: 13213
/// </summary>
public abstract class Pionus : Psittacidae, IPionus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pionus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13213;

    /// <inheritdoc />
    public virtual string GenusName => "Pionus";

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
