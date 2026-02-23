using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Nestor;

/// <summary>
/// Abstract class for Nestor (genus).
/// NCBI TaxId: 176042
/// </summary>
public abstract class Nestor : Psittacidae, INestor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nestor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176042;

    /// <inheritdoc />
    public virtual string GenusName => "Nestor";

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
