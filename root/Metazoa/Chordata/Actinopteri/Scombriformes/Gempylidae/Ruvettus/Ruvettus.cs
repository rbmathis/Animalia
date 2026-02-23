using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Ruvettus;

/// <summary>
/// Abstract class for Ruvettus (genus).
/// NCBI TaxId: 13661
/// </summary>
public abstract class Ruvettus : Gempylidae, IRuvettus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ruvettus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13661;

    /// <inheritdoc />
    public virtual string GenusName => "Ruvettus";

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
