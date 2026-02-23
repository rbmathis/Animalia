using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Chalarodon;

/// <summary>
/// Abstract class for Chalarodon (genus).
/// NCBI TaxId: 44146
/// </summary>
public abstract class Chalarodon : Iguanidae, IChalarodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalarodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44146;

    /// <inheritdoc />
    public virtual string GenusName => "Chalarodon";

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
