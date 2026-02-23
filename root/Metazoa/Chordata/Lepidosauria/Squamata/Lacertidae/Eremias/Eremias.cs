using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Eremias;

/// <summary>
/// Abstract class for Eremias (genus).
/// NCBI TaxId: 52178
/// </summary>
public abstract class Eremias : Lacertidae, IEremias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52178;

    /// <inheritdoc />
    public virtual string GenusName => "Eremias";

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
