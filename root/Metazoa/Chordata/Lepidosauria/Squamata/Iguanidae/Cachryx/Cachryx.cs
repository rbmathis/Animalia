using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Cachryx;

/// <summary>
/// Abstract class for Cachryx (genus).
/// NCBI TaxId: 2023063
/// </summary>
public abstract class Cachryx : Iguanidae, ICachryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cachryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023063;

    /// <inheritdoc />
    public virtual string GenusName => "Cachryx";

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
