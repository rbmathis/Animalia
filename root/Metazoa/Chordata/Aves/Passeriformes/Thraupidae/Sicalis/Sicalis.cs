using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Sicalis;

/// <summary>
/// Abstract class for Sicalis (genus).
/// NCBI TaxId: 163866
/// </summary>
public abstract class Sicalis : Thraupidae, ISicalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sicalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163866;

    /// <inheritdoc />
    public virtual string GenusName => "Sicalis";

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
