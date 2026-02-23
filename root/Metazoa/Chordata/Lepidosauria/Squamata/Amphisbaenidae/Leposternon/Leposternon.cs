using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Leposternon;

/// <summary>
/// Abstract class for Leposternon (genus).
/// NCBI TaxId: 261491
/// </summary>
public abstract class Leposternon : Amphisbaenidae, ILeposternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leposternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261491;

    /// <inheritdoc />
    public virtual string GenusName => "Leposternon";

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
