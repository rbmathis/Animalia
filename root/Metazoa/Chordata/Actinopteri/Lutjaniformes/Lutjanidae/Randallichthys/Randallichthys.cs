using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Randallichthys;

/// <summary>
/// Abstract class for Randallichthys (genus).
/// NCBI TaxId: 1522436
/// </summary>
public abstract class Randallichthys : Lutjanidae, IRandallichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Randallichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1522436;

    /// <inheritdoc />
    public virtual string GenusName => "Randallichthys";

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
