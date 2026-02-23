using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Gempylus;

/// <summary>
/// Abstract class for Gempylus (genus).
/// NCBI TaxId: 13542
/// </summary>
public abstract class Gempylus : Gempylidae, IGempylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gempylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13542;

    /// <inheritdoc />
    public virtual string GenusName => "Gempylus";

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
