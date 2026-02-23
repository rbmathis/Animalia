using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Sphaerodactylidae.Aristelliger;

/// <summary>
/// Abstract class for Aristelliger (genus).
/// NCBI TaxId: 460615
/// </summary>
public abstract class Aristelliger : Sphaerodactylidae, IAristelliger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aristelliger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460615;

    /// <inheritdoc />
    public virtual string GenusName => "Aristelliger";

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
