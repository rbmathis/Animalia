using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Hydrodynastes;

/// <summary>
/// Abstract class for Hydrodynastes (genus).
/// NCBI TaxId: 121333
/// </summary>
public abstract class Hydrodynastes : Dipsadidae, IHydrodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121333;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrodynastes";

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
