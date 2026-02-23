using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittaculidae.Psephotellus;

/// <summary>
/// Abstract class for Psephotellus (genus).
/// NCBI TaxId: 1804610
/// </summary>
public abstract class Psephotellus : Psittaculidae, IPsephotellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psephotellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1804610;

    /// <inheritdoc />
    public virtual string GenusName => "Psephotellus";

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
