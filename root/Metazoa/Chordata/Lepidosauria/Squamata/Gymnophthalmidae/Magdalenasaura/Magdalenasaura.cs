using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Magdalenasaura;

/// <summary>
/// Abstract class for Magdalenasaura (genus).
/// NCBI TaxId: 2813953
/// </summary>
public abstract class Magdalenasaura : Gymnophthalmidae, IMagdalenasaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Magdalenasaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2813953;

    /// <inheritdoc />
    public virtual string GenusName => "Magdalenasaura";

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
