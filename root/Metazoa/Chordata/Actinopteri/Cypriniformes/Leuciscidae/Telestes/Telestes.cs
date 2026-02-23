using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Telestes;

/// <summary>
/// Abstract class for Telestes (genus).
/// NCBI TaxId: 103461
/// </summary>
public abstract class Telestes : Leuciscidae, ITelestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Telestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103461;

    /// <inheritdoc />
    public virtual string GenusName => "Telestes";

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
