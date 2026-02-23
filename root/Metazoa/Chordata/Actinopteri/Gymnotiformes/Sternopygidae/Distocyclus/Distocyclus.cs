using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Distocyclus;

/// <summary>
/// Abstract class for Distocyclus (genus).
/// NCBI TaxId: 36705
/// </summary>
public abstract class Distocyclus : Sternopygidae, IDistocyclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Distocyclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36705;

    /// <inheritdoc />
    public virtual string GenusName => "Distocyclus";

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
