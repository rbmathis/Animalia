using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Anguis;

/// <summary>
/// Abstract class for Anguis (genus).
/// NCBI TaxId: 102177
/// </summary>
public abstract class Anguis : Anguidae, IAnguis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anguis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 102177;

    /// <inheritdoc />
    public virtual string GenusName => "Anguis";

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
