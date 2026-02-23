using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Psammophylax;

/// <summary>
/// Abstract class for Psammophylax (genus).
/// NCBI TaxId: 211602
/// </summary>
public abstract class Psammophylax : Lamprophiidae, IPsammophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 211602;

    /// <inheritdoc />
    public virtual string GenusName => "Psammophylax";

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
