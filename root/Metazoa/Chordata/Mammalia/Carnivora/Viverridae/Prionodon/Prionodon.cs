using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Prionodon;

/// <summary>
/// Abstract class for Prionodon (genus).
/// NCBI TaxId: 94193
/// </summary>
public abstract class Prionodon : Viverridae, IPrionodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94193;

    /// <inheritdoc />
    public virtual string GenusName => "Prionodon";

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
