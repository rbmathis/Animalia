using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Iberochondrostoma;

/// <summary>
/// Abstract class for Iberochondrostoma (genus).
/// NCBI TaxId: 437165
/// </summary>
public abstract class Iberochondrostoma : Leuciscidae, IIberochondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iberochondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 437165;

    /// <inheritdoc />
    public virtual string GenusName => "Iberochondrostoma";

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
