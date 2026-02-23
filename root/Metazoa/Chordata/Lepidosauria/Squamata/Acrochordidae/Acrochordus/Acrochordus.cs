using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae.Acrochordus;

/// <summary>
/// Abstract class for Acrochordus (genus).
/// NCBI TaxId: 39234
/// </summary>
public abstract class Acrochordus : Acrochordidae, IAcrochordus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acrochordus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39234;

    /// <inheritdoc />
    public virtual string GenusName => "Acrochordus";

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
