using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Thamnodynastes;

/// <summary>
/// Abstract class for Thamnodynastes (genus).
/// NCBI TaxId: 121371
/// </summary>
public abstract class Thamnodynastes : Dipsadidae, IThamnodynastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thamnodynastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121371;

    /// <inheritdoc />
    public virtual string GenusName => "Thamnodynastes";

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
