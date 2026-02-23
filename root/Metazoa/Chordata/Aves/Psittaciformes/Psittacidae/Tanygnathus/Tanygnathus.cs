using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Tanygnathus;

/// <summary>
/// Abstract class for Tanygnathus (genus).
/// NCBI TaxId: 274072
/// </summary>
public abstract class Tanygnathus : Psittacidae, ITanygnathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tanygnathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274072;

    /// <inheritdoc />
    public virtual string GenusName => "Tanygnathus";

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
