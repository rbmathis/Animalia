using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaniolepididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zaniolepididae.Zaniolepis;

/// <summary>
/// Abstract class for Zaniolepis (genus).
/// NCBI TaxId: 274742
/// </summary>
public abstract class Zaniolepis : Zaniolepididae, IZaniolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zaniolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274742;

    /// <inheritdoc />
    public virtual string GenusName => "Zaniolepis";

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
