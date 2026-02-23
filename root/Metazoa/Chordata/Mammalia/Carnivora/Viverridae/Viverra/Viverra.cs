using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Viverra;

/// <summary>
/// Abstract class for Viverra (genus).
/// NCBI TaxId: 71120
/// </summary>
public abstract class Viverra : Viverridae, IViverra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Viverra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71120;

    /// <inheritdoc />
    public virtual string GenusName => "Viverra";

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
