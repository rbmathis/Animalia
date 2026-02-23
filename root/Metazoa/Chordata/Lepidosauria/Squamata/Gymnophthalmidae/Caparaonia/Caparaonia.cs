using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Caparaonia;

/// <summary>
/// Abstract class for Caparaonia (genus).
/// NCBI TaxId: 1331292
/// </summary>
public abstract class Caparaonia : Gymnophthalmidae, ICaparaonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caparaonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1331292;

    /// <inheritdoc />
    public virtual string GenusName => "Caparaonia";

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
