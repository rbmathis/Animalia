using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Hephaestus;

/// <summary>
/// Abstract class for Hephaestus (genus).
/// NCBI TaxId: 443787
/// </summary>
public abstract class Hephaestus : Terapontidae, IHephaestus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hephaestus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443787;

    /// <inheritdoc />
    public virtual string GenusName => "Hephaestus";

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
