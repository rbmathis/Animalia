using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Callopistes;

/// <summary>
/// Abstract class for Callopistes (genus).
/// NCBI TaxId: 271258
/// </summary>
public abstract class Callopistes : Teiidae, ICallopistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callopistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 271258;

    /// <inheritdoc />
    public virtual string GenusName => "Callopistes";

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
