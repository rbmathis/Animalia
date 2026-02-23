using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Boehlkea;

/// <summary>
/// Abstract class for Boehlkea (genus).
/// NCBI TaxId: 2283130
/// </summary>
public abstract class Boehlkea : Stevardiidae, IBoehlkea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boehlkea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2283130;

    /// <inheritdoc />
    public virtual string GenusName => "Boehlkea";

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
