using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Centrochir;

/// <summary>
/// Abstract class for Centrochir (genus).
/// NCBI TaxId: 1312657
/// </summary>
public abstract class Centrochir : Doradidae, ICentrochir
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrochir";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312657;

    /// <inheritdoc />
    public virtual string GenusName => "Centrochir";

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
