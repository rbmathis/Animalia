using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Rhinodoras;

/// <summary>
/// Abstract class for Rhinodoras (genus).
/// NCBI TaxId: 238579
/// </summary>
public abstract class Rhinodoras : Doradidae, IRhinodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238579;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinodoras";

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
