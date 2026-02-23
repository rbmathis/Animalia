using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phytotriades;

/// <summary>
/// Abstract class for Phytotriades (genus).
/// NCBI TaxId: 2728968
/// </summary>
public abstract class Phytotriades : Hylidae, IPhytotriades
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phytotriades";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2728968;

    /// <inheritdoc />
    public virtual string GenusName => "Phytotriades";

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
