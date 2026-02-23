using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Hemiergis;

/// <summary>
/// Abstract class for Hemiergis (genus).
/// NCBI TaxId: 220784
/// </summary>
public abstract class Hemiergis : Scincidae, IHemiergis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemiergis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220784;

    /// <inheritdoc />
    public virtual string GenusName => "Hemiergis";

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
