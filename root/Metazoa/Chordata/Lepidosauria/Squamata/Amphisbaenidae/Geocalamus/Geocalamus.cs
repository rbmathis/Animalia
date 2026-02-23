using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Geocalamus;

/// <summary>
/// Abstract class for Geocalamus (genus).
/// NCBI TaxId: 261497
/// </summary>
public abstract class Geocalamus : Amphisbaenidae, IGeocalamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geocalamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 261497;

    /// <inheritdoc />
    public virtual string GenusName => "Geocalamus";

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
