using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Neoarius;

/// <summary>
/// Abstract class for Neoarius (genus).
/// NCBI TaxId: 475172
/// </summary>
public abstract class Neoarius : Ariidae, INeoarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 475172;

    /// <inheritdoc />
    public virtual string GenusName => "Neoarius";

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
