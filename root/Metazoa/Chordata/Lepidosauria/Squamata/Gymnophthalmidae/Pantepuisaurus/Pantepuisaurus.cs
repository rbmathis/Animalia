using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Pantepuisaurus;

/// <summary>
/// Abstract class for Pantepuisaurus (genus).
/// NCBI TaxId: 1221496
/// </summary>
public abstract class Pantepuisaurus : Gymnophthalmidae, IPantepuisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pantepuisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1221496;

    /// <inheritdoc />
    public virtual string GenusName => "Pantepuisaurus";

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
