using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Laticauda;

/// <summary>
/// Abstract class for Laticauda (genus).
/// NCBI TaxId: 8627
/// </summary>
public abstract class Laticauda : Elapidae, ILaticauda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laticauda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8627;

    /// <inheritdoc />
    public virtual string GenusName => "Laticauda";

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
