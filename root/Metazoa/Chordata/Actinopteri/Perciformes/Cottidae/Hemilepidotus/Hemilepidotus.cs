using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Hemilepidotus;

/// <summary>
/// Abstract class for Hemilepidotus (genus).
/// NCBI TaxId: 238837
/// </summary>
public abstract class Hemilepidotus : Cottidae, IHemilepidotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemilepidotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238837;

    /// <inheritdoc />
    public virtual string GenusName => "Hemilepidotus";

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
