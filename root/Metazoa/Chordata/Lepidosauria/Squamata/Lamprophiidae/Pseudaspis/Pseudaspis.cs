using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Pseudaspis;

/// <summary>
/// Abstract class for Pseudaspis (genus).
/// NCBI TaxId: 184167
/// </summary>
public abstract class Pseudaspis : Lamprophiidae, IPseudaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184167;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudaspis";

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
