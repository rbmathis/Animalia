using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae.Boulengerella;

/// <summary>
/// Abstract class for Boulengerella (genus).
/// NCBI TaxId: 27691
/// </summary>
public abstract class Boulengerella : Ctenoluciidae, IBoulengerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boulengerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27691;

    /// <inheritdoc />
    public virtual string GenusName => "Boulengerella";

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
