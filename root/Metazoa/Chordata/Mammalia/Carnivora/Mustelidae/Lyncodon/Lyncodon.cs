using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lyncodon;

/// <summary>
/// Abstract class for Lyncodon (genus).
/// NCBI TaxId: 768573
/// </summary>
public abstract class Lyncodon : Mustelidae, ILyncodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyncodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 768573;

    /// <inheritdoc />
    public virtual string GenusName => "Lyncodon";

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
