using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Quedenfeldtia;

/// <summary>
/// Abstract class for Quedenfeldtia (genus).
/// NCBI TaxId: 460630
/// </summary>
public abstract class Quedenfeldtia : Sphaerodactylidae, IQuedenfeldtia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Quedenfeldtia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460630;

    /// <inheritdoc />
    public virtual string GenusName => "Quedenfeldtia";

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
