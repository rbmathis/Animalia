using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Prioniturus;

/// <summary>
/// Abstract class for Prioniturus (genus).
/// NCBI TaxId: 309872
/// </summary>
public abstract class Prioniturus : Psittacidae, IPrioniturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prioniturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 309872;

    /// <inheritdoc />
    public virtual string GenusName => "Prioniturus";

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
