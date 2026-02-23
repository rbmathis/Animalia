using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Pedioplanis;

/// <summary>
/// Abstract class for Pedioplanis (genus).
/// NCBI TaxId: 71733
/// </summary>
public abstract class Pedioplanis : Lacertidae, IPedioplanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pedioplanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71733;

    /// <inheritdoc />
    public virtual string GenusName => "Pedioplanis";

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
