using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psephotus;

/// <summary>
/// Abstract class for Psephotus (genus).
/// NCBI TaxId: 176046
/// </summary>
public abstract class Psephotus : Psittacidae, IPsephotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psephotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176046;

    /// <inheritdoc />
    public virtual string GenusName => "Psephotus";

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
