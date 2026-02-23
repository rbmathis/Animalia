using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Pomatomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Pomatomidae.Pomatomus;

/// <summary>
/// Abstract class for Pomatomus (genus).
/// NCBI TaxId: 75033
/// </summary>
public abstract class Pomatomus : Pomatomidae, IPomatomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomatomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75033;

    /// <inheritdoc />
    public virtual string GenusName => "Pomatomus";

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
