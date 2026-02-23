using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Matoatoa;

/// <summary>
/// Abstract class for Matoatoa (genus).
/// NCBI TaxId: 454305
/// </summary>
public abstract class Matoatoa : Gekkonidae, IMatoatoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Matoatoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 454305;

    /// <inheritdoc />
    public virtual string GenusName => "Matoatoa";

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
