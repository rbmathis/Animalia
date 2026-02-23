using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Macroscelidea.Macroscelididae.Galegeeska;

/// <summary>
/// Abstract class for Galegeeska (genus).
/// NCBI TaxId: 2819854
/// </summary>
public abstract class Galegeeska : Macroscelididae, IGalegeeska
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galegeeska";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819854;

    /// <inheritdoc />
    public virtual string GenusName => "Galegeeska";

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
