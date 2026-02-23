using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Notaden;

/// <summary>
/// Abstract class for Notaden (genus).
/// NCBI TaxId: 51253
/// </summary>
public abstract class Notaden : Limnodynastidae, INotaden
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notaden";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51253;

    /// <inheritdoc />
    public virtual string GenusName => "Notaden";

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
