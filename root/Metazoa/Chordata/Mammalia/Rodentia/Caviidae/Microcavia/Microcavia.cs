using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Microcavia;

/// <summary>
/// Abstract class for Microcavia (genus).
/// NCBI TaxId: 181540
/// </summary>
public abstract class Microcavia : Caviidae, IMicrocavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181540;

    /// <inheritdoc />
    public virtual string GenusName => "Microcavia";

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
