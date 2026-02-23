using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Gadiculus;

/// <summary>
/// Abstract class for Gadiculus (genus).
/// NCBI TaxId: 185736
/// </summary>
public abstract class Gadiculus : Gadidae, IGadiculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gadiculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 185736;

    /// <inheritdoc />
    public virtual string GenusName => "Gadiculus";

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
