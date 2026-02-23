using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Cyanoramphus;

/// <summary>
/// Abstract class for Cyanoramphus (genus).
/// NCBI TaxId: 114431
/// </summary>
public abstract class Cyanoramphus : Psittacidae, ICyanoramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanoramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114431;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanoramphus";

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
