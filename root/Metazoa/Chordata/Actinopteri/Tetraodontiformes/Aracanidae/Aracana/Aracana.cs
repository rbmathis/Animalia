using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae.Aracana;

/// <summary>
/// Abstract class for Aracana (genus).
/// NCBI TaxId: 303738
/// </summary>
public abstract class Aracana : Aracanidae, IAracana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aracana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303738;

    /// <inheritdoc />
    public virtual string GenusName => "Aracana";

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
