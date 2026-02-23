using AnimalKingdom.root.Metazoa.Chordata.Coelacanthiformes.Coelacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Coelacanthiformes.Coelacanthidae.Latimeria;

/// <summary>
/// Abstract class for Latimeria (genus).
/// NCBI TaxId: 7896
/// </summary>
public abstract class Latimeria : Coelacanthidae, ILatimeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Latimeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7896;

    /// <inheritdoc />
    public virtual string GenusName => "Latimeria";

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
