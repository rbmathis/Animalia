using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pelturagonia;

/// <summary>
/// Abstract class for Pelturagonia (genus).
/// NCBI TaxId: 2652439
/// </summary>
public abstract class Pelturagonia : Agamidae, IPelturagonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelturagonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2652439;

    /// <inheritdoc />
    public virtual string GenusName => "Pelturagonia";

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
