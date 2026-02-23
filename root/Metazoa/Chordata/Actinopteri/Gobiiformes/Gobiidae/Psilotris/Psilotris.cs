using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Psilotris;

/// <summary>
/// Abstract class for Psilotris (genus).
/// NCBI TaxId: 203329
/// </summary>
public abstract class Psilotris : Gobiidae, IPsilotris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilotris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 203329;

    /// <inheritdoc />
    public virtual string GenusName => "Psilotris";

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
