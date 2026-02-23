using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Leucippus;

/// <summary>
/// Abstract class for Leucippus (genus).
/// NCBI TaxId: 689222
/// </summary>
public abstract class Leucippus : Trochilidae, ILeucippus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucippus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689222;

    /// <inheritdoc />
    public virtual string GenusName => "Leucippus";

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
