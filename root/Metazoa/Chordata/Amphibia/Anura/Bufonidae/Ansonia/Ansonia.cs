using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ansonia;

/// <summary>
/// Abstract class for Ansonia (genus).
/// NCBI TaxId: 47576
/// </summary>
public abstract class Ansonia : Bufonidae, IAnsonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ansonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47576;

    /// <inheritdoc />
    public virtual string GenusName => "Ansonia";

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
