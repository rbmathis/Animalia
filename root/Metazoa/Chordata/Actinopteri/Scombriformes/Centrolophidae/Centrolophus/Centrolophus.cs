using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Centrolophus;

/// <summary>
/// Abstract class for Centrolophus (genus).
/// NCBI TaxId: 316129
/// </summary>
public abstract class Centrolophus : Centrolophidae, ICentrolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316129;

    /// <inheritdoc />
    public virtual string GenusName => "Centrolophus";

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
