using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Calyptophilus;

/// <summary>
/// Abstract class for Calyptophilus (genus).
/// NCBI TaxId: 340436
/// </summary>
public abstract class Calyptophilus : Thraupidae, ICalyptophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 340436;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptophilus";

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
