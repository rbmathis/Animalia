using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Lagostrophus;

/// <summary>
/// Abstract class for Lagostrophus (genus).
/// NCBI TaxId: 65633
/// </summary>
public abstract class Lagostrophus : Macropodidae, ILagostrophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagostrophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 65633;

    /// <inheritdoc />
    public virtual string GenusName => "Lagostrophus";

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
