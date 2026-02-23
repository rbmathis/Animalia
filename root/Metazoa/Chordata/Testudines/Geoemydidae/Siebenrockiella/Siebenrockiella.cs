using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Siebenrockiella;

/// <summary>
/// Abstract class for Siebenrockiella (genus).
/// NCBI TaxId: 72007
/// </summary>
public abstract class Siebenrockiella : Geoemydidae, ISiebenrockiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siebenrockiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72007;

    /// <inheritdoc />
    public virtual string GenusName => "Siebenrockiella";

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
