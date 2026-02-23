using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Phrygilus;

/// <summary>
/// Abstract class for Phrygilus (genus).
/// NCBI TaxId: 137212
/// </summary>
public abstract class Phrygilus : Thraupidae, IPhrygilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrygilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137212;

    /// <inheritdoc />
    public virtual string GenusName => "Phrygilus";

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
