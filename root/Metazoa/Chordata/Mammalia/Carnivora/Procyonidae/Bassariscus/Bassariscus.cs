using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Bassariscus;

/// <summary>
/// Abstract class for Bassariscus (genus).
/// NCBI TaxId: 55046
/// </summary>
public abstract class Bassariscus : Procyonidae, IBassariscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bassariscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55046;

    /// <inheritdoc />
    public virtual string GenusName => "Bassariscus";

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
