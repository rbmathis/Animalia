using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Darevskia;

/// <summary>
/// Abstract class for Darevskia (genus).
/// NCBI TaxId: 122330
/// </summary>
public abstract class Darevskia : Lacertidae, IDarevskia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Darevskia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 122330;

    /// <inheritdoc />
    public virtual string GenusName => "Darevskia";

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
