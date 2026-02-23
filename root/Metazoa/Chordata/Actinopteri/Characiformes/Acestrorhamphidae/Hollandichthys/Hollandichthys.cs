using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Hollandichthys;

/// <summary>
/// Abstract class for Hollandichthys (genus).
/// NCBI TaxId: 681945
/// </summary>
public abstract class Hollandichthys : Acestrorhamphidae, IHollandichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hollandichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681945;

    /// <inheritdoc />
    public virtual string GenusName => "Hollandichthys";

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
