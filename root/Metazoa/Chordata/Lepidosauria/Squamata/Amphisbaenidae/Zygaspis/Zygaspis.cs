using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Zygaspis;

/// <summary>
/// Abstract class for Zygaspis (genus).
/// NCBI TaxId: 1395501
/// </summary>
public abstract class Zygaspis : Amphisbaenidae, IZygaspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zygaspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1395501;

    /// <inheritdoc />
    public virtual string GenusName => "Zygaspis";

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
