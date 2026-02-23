using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Cardioglossa;

/// <summary>
/// Abstract class for Cardioglossa (genus).
/// NCBI TaxId: 111121
/// </summary>
public abstract class Cardioglossa : Arthroleptidae, ICardioglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cardioglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111121;

    /// <inheritdoc />
    public virtual string GenusName => "Cardioglossa";

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
