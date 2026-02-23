using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Triclaria;

/// <summary>
/// Abstract class for Triclaria (genus).
/// NCBI TaxId: 303325
/// </summary>
public abstract class Triclaria : Psittacidae, ITriclaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Triclaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303325;

    /// <inheritdoc />
    public virtual string GenusName => "Triclaria";

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
