using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Lithodoras;

/// <summary>
/// Abstract class for Lithodoras (genus).
/// NCBI TaxId: 238573
/// </summary>
public abstract class Lithodoras : Doradidae, ILithodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238573;

    /// <inheritdoc />
    public virtual string GenusName => "Lithodoras";

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
