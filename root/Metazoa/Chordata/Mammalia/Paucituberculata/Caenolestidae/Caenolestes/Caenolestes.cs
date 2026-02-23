using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Paucituberculata.Caenolestidae.Caenolestes;

/// <summary>
/// Abstract class for Caenolestes (genus).
/// NCBI TaxId: 37886
/// </summary>
public abstract class Caenolestes : Caenolestidae, ICaenolestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caenolestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37886;

    /// <inheritdoc />
    public virtual string GenusName => "Caenolestes";

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
