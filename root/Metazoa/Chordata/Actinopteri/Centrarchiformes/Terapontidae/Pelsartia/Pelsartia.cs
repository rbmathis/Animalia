using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Pelsartia;

/// <summary>
/// Abstract class for Pelsartia (genus).
/// NCBI TaxId: 1161375
/// </summary>
public abstract class Pelsartia : Terapontidae, IPelsartia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelsartia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1161375;

    /// <inheritdoc />
    public virtual string GenusName => "Pelsartia";

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
