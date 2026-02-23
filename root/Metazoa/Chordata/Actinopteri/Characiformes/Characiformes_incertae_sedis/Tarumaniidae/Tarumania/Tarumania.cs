using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characiformes_incertae_sedis.Tarumaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characiformes_incertae_sedis.Tarumaniidae.Tarumania;

/// <summary>
/// Abstract class for Tarumania (genus).
/// NCBI TaxId: 2283323
/// </summary>
public abstract class Tarumania : Tarumaniidae, ITarumania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarumania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2283323;

    /// <inheritdoc />
    public virtual string GenusName => "Tarumania";

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
