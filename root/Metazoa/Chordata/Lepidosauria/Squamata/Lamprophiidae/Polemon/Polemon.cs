using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Polemon;

/// <summary>
/// Abstract class for Polemon (genus).
/// NCBI TaxId: 292859
/// </summary>
public abstract class Polemon : Lamprophiidae, IPolemon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polemon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292859;

    /// <inheritdoc />
    public virtual string GenusName => "Polemon";

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
