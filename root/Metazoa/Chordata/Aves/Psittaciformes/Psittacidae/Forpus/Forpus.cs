using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Forpus;

/// <summary>
/// Abstract class for Forpus (genus).
/// NCBI TaxId: 69956
/// </summary>
public abstract class Forpus : Psittacidae, IForpus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Forpus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69956;

    /// <inheritdoc />
    public virtual string GenusName => "Forpus";

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
