using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Lankanectes;

/// <summary>
/// Abstract class for Lankanectes (genus).
/// NCBI TaxId: 272189
/// </summary>
public abstract class Lankanectes : Nyctibatrachidae, ILankanectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lankanectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272189;

    /// <inheritdoc />
    public virtual string GenusName => "Lankanectes";

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
