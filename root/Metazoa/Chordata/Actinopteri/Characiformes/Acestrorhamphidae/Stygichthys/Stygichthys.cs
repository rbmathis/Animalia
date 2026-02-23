using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Stygichthys;

/// <summary>
/// Abstract class for Stygichthys (genus).
/// NCBI TaxId: 930384
/// </summary>
public abstract class Stygichthys : Acestrorhamphidae, IStygichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stygichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930384;

    /// <inheritdoc />
    public virtual string GenusName => "Stygichthys";

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
