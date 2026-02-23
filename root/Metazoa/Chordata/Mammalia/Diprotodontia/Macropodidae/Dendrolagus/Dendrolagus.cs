using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Dendrolagus;

/// <summary>
/// Abstract class for Dendrolagus (genus).
/// NCBI TaxId: 38603
/// </summary>
public abstract class Dendrolagus : Macropodidae, IDendrolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38603;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrolagus";

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
