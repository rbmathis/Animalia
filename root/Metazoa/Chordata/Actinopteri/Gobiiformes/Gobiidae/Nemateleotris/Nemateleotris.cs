using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Nemateleotris;

/// <summary>
/// Abstract class for Nemateleotris (genus).
/// NCBI TaxId: 150308
/// </summary>
public abstract class Nemateleotris : Gobiidae, INemateleotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nemateleotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150308;

    /// <inheritdoc />
    public virtual string GenusName => "Nemateleotris";

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
