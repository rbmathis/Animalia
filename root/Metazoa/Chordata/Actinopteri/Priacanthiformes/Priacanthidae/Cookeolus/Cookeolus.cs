using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Cookeolus;

/// <summary>
/// Abstract class for Cookeolus (genus).
/// NCBI TaxId: 390313
/// </summary>
public abstract class Cookeolus : Priacanthidae, ICookeolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cookeolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390313;

    /// <inheritdoc />
    public virtual string GenusName => "Cookeolus";

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
