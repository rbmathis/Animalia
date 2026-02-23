using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Ramphocelus;

/// <summary>
/// Abstract class for Ramphocelus (genus).
/// NCBI TaxId: 36724
/// </summary>
public abstract class Ramphocelus : Thraupidae, IRamphocelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ramphocelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36724;

    /// <inheritdoc />
    public virtual string GenusName => "Ramphocelus";

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
