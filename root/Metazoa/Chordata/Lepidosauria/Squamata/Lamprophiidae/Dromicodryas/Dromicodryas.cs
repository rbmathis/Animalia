using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Dromicodryas;

/// <summary>
/// Abstract class for Dromicodryas (genus).
/// NCBI TaxId: 143564
/// </summary>
public abstract class Dromicodryas : Lamprophiidae, IDromicodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dromicodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143564;

    /// <inheritdoc />
    public virtual string GenusName => "Dromicodryas";

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
