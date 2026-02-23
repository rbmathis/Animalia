using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae.Vombatus;

/// <summary>
/// Abstract class for Vombatus (genus).
/// NCBI TaxId: 29138
/// </summary>
public abstract class Vombatus : Vombatidae, IVombatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vombatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29138;

    /// <inheritdoc />
    public virtual string GenusName => "Vombatus";

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
