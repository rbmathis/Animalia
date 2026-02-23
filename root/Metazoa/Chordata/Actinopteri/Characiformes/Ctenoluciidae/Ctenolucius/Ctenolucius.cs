using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Ctenoluciidae.Ctenolucius;

/// <summary>
/// Abstract class for Ctenolucius (genus).
/// NCBI TaxId: 42604
/// </summary>
public abstract class Ctenolucius : Ctenoluciidae, ICtenolucius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenolucius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42604;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenolucius";

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
