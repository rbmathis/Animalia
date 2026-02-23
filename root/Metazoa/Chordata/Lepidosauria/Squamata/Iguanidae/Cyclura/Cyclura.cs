using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Cyclura;

/// <summary>
/// Abstract class for Cyclura (genus).
/// NCBI TaxId: 51213
/// </summary>
public abstract class Cyclura : Iguanidae, ICyclura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51213;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclura";

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
