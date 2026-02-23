using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Stromateidae.Pampus;

/// <summary>
/// Abstract class for Pampus (genus).
/// NCBI TaxId: 163125
/// </summary>
public abstract class Pampus : Stromateidae, IPampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163125;

    /// <inheritdoc />
    public virtual string GenusName => "Pampus";

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
