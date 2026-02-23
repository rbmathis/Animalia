using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Psittacus;

/// <summary>
/// Abstract class for Psittacus (genus).
/// NCBI TaxId: 13239
/// </summary>
public abstract class Psittacus : Psittacidae, IPsittacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13239;

    /// <inheritdoc />
    public virtual string GenusName => "Psittacus";

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
