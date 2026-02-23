using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Hemidoras;

/// <summary>
/// Abstract class for Hemidoras (genus).
/// NCBI TaxId: 238611
/// </summary>
public abstract class Hemidoras : Doradidae, IHemidoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemidoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238611;

    /// <inheritdoc />
    public virtual string GenusName => "Hemidoras";

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
