using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Duberria;

/// <summary>
/// Abstract class for Duberria (genus).
/// NCBI TaxId: 186584
/// </summary>
public abstract class Duberria : Lamprophiidae, IDuberria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Duberria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186584;

    /// <inheritdoc />
    public virtual string GenusName => "Duberria";

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
