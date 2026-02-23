using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Plica;

/// <summary>
/// Abstract class for Plica (genus).
/// NCBI TaxId: 179264
/// </summary>
public abstract class Plica : Iguanidae, IPlica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 179264;

    /// <inheritdoc />
    public virtual string GenusName => "Plica";

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
