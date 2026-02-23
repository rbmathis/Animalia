using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Lechriodus;

/// <summary>
/// Abstract class for Lechriodus (genus).
/// NCBI TaxId: 288788
/// </summary>
public abstract class Lechriodus : Limnodynastidae, ILechriodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lechriodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288788;

    /// <inheritdoc />
    public virtual string GenusName => "Lechriodus";

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
