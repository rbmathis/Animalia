using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Dopasia;

/// <summary>
/// Abstract class for Dopasia (genus).
/// NCBI TaxId: 1469810
/// </summary>
public abstract class Dopasia : Anguidae, IDopasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dopasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1469810;

    /// <inheritdoc />
    public virtual string GenusName => "Dopasia";

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
