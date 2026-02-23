using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Hemicordylus;

/// <summary>
/// Abstract class for Hemicordylus (genus).
/// NCBI TaxId: 885524
/// </summary>
public abstract class Hemicordylus : Cordylidae, IHemicordylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemicordylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 885524;

    /// <inheritdoc />
    public virtual string GenusName => "Hemicordylus";

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
