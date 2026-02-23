using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Landonia;

/// <summary>
/// Abstract class for Landonia (genus).
/// NCBI TaxId: 1463122
/// </summary>
public abstract class Landonia : Stevardiidae, ILandonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Landonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463122;

    /// <inheritdoc />
    public virtual string GenusName => "Landonia";

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
